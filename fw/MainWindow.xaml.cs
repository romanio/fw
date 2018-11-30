using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

namespace fw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MainWindowModel model = new MainWindowModel();
        GLControl glControl = null;

        public MainWindow()
        {
            DataContext = model;
            InitializeComponent();
            glControl = new GLControl(GraphicsMode.Default, 3, 3, GraphicsContextFlags.Default);
            HostGL.Child = glControl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog() { Filter = "BDExcel|*.xlsx" };
            if (fileDialog.ShowDialog() == true)
            {
                model.OpenBDExcel(fileDialog.FileName);
            }

        }

        List<string> SelectedLayers = new List<string>();
        List<string> SelectedWells = new List<string>();

        private void OnWellnamesSelected(object sender, SelectionChangedEventArgs e)
        {
            var tmp = (sender as ListBox).SelectedItems;
            SelectedWells.Clear();

            foreach (object item in tmp)
            {
                SelectedWells.Add(item.ToString());
            }
            UpdateChart();
        }

        private void OnLayersSelected(object sender, SelectionChangedEventArgs e)
        {
            SelectedLayers.Clear();
            var tmp = (sender as ListBox).SelectedItems;
            foreach (object item in tmp)
            {
                SelectedLayers.Add(item.ToString());
            }
            UpdateChart();
        }

        void UpdateChart()
        {
            if (SelectedLayers.Count == 0) return;
            if (SelectedWells.Count == 0) return;

            model.UpdateChart(SelectedLayers, SelectedWells);
        }

            // Generate chart title

            /*
            if (checkRates.IsChecked.Value)
            {
                chart.ChartAreas[0].AxisY.Title = "[m3/day]";
            }
            else
            {
                chart.ChartAreas[0].AxisY.Title = "[m3]";
            }


            //
            chart.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart.ChartAreas[0].AxisY.Maximum = double.NaN;
            chart.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart.ChartAreas[0].RecalculateAxesScale();


            // GTM
            for (int it = 0; it < model.dates.Count; ++it)
            {
                if (res[it] != null)
                {
                    if (res[it].gtm != null)
                    {
                        if (res[it].liquid > 0)
                        {
                            chart.Series[1].Points[it].MarkerStyle = MarkerStyle.Circle;
                            chart.Series[1].Points[it].MarkerSize = 7;
                            chart.Series[1].Points[it].MarkerColor = System.Drawing.Color.LawnGreen;
                            chart.Series[1].Points[it].Label = res[it].gtm;
                        }
                        if (res[it].winj > 0)
                        {
                            chart.Series[3].Points[it].MarkerStyle = MarkerStyle.Circle;
                            chart.Series[3].Points[it].MarkerSize = 7;
                            chart.Series[3].Points[it].MarkerColor = System.Drawing.Color.LawnGreen;
                            chart.Series[3].Points[it].Label = res[it].gtm;
                        }
                    }
                }
            }
        }
        */
        
        private void checkRates_Click(object sender, RoutedEventArgs e)
        {
            UpdateChart();
        }

        private int CompileShaders()
        {
            var vertexShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vertexShader, VertexShader);
            GL.CompileShader(vertexShader);

            var fragmentShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(fragmentShader, FragmentShader);
            GL.CompileShader(fragmentShader);

            var program = GL.CreateProgram();
            GL.AttachShader(program, vertexShader);
            GL.AttachShader(program, fragmentShader);
            GL.LinkProgram(program);

            GL.DetachShader(program, vertexShader);
            GL.DetachShader(program, fragmentShader);
            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);

            return program;
        }

        private void GlControl_Resize(object sender, EventArgs e)
        {
            GL.Viewport(glControl.Size);
            GlControl_Paint(null, null);
        }

        int _program;
        int _vertexArray;
        float[] vertices = new float[] { 0.5f, -0.5f, 0.0f, 0.5f, -0.5f, 0.0f, 0.0f, 0.5f, 0.0f };
        int VBO, VAO;

        private void GlControl_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            _program = CompileShaders();
            System.Diagnostics.Debug.WriteLine(GL.GetProgramInfoLog(_program));

            GL.GenVertexArrays(1, out VAO);
            GL.GenBuffers(1, out VBO);

            // bind the Vertex Array Object first, then bind and set vertex buffer(s), and then configure vertex attributes(s).
            GL.BindVertexArray(VAO);
            GL.BindBuffer(BufferTarget.ArrayBuffer, VBO);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float) * 3, vertices, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            /*
            GL.GenVertexArrays(1, out _vertexArray);
            GL.BindVertexArray(_vertexArray);

            Title = "OpenGL Version " + GL.GetString(StringName.Version) + " " + _program;
            */

        }

        private void GlControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            double _time = DateTime.Now.Second * 0.1;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.UseProgram(_program);
            GL.PointSize(10);

            GL.VertexAttrib1(0, _time);
            Vector4 position;
            position.X = (float)Math.Sin(_time) * 0.5f;
            position.Y = (float)Math.Cos(_time) * 0.5f;
            position.Z = 0.0f;
            position.W = 1.0f;
            GL.VertexAttrib4(1, position);

            GL.DrawArrays(PrimitiveType.Points, 0, 1);
            glControl.SwapBuffers();
        }

        string VertexShader =
    "#version 330 core\n" +
    "\n" +
    "layout (location=0) in float time;\n" +
    "layout (location=1) in vec4 position;\n" +
    "out vec4 frag_color;\n" +
    "void main(void)\n" +
    "{\n" +
    "  gl_Position = position;\n" +
    "  frag_color = vec4(sin(time) * 0.5 + 0.5, cos(time) * 0.5 + 0.5, 0.0, 0.0);\n" +
    "}\n";

        string FragmentShader =
            "#version 330 core\n" +
            "in vec4 frag_color;\n" +
            "out vec4 color;\n" +
            "\n" +
            "void main(void)\n" +
            "{\n" +
            "   color = frag_color;\n" +
            "}\n";

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GL.DeleteVertexArrays(1, ref _vertexArray);
            GL.DeleteProgram(_program);
        }

        private void HostGL_KeyDown(object sender, KeyEventArgs e)
        {
            GlControl_Paint(null, null);
        }
    }

}

