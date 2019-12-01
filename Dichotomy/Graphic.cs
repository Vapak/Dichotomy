using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dichotomy
{
    public partial class Graphic : Form
    {
        private ZedGraph.ZedGraphControl z1 = new ZedGraph.ZedGraphControl();

        public Graphic()
        {
            InitializeComponent();
        }

        private void Graphic_Load(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Class1 math = new Class1();


            z1 = zedGraphControl1;
            z1.IsShowPointValues = true;
            z1.GraphPane.Title = String.Format(format: "График функции " + Data.formula.ToString());
            z1.GraphPane.XAxis.Title = "x";
            z1.GraphPane.YAxis.Title = "f(x)";

            int n = 100;
            double a = Data.ans - n / 2 - 1;

            double[] x = new double[n];
            double[] y = new double[n];

            double[] xp = new double[1];
            
            double[] yp = new double[1];
            

            for (int i = 0; i < n; i++)
            {
                x[i] = (double)(a + i)/10;
                y[i] = math.func(x[i]);
            }
            xp[0] = Data.ans;
            yp[0] = math.func(Data.ans);

            z1.GraphPane.AddCurve("y(x)", x, y, Color.Red, ZedGraph.SymbolType.None);
            z1.GraphPane.AddCurve("", xp, yp, Color.SkyBlue, ZedGraph.SymbolType.Circle);
            z1.AxisChange();
            z1.Invalidate();
        }
    }
}
