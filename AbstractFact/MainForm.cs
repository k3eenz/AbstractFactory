using AbstractFactory.Factories;

namespace AbstractFact
{
    public partial class MainForm : Form
    {
        private AbstractShapeFactory currentFactory;
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateFactory()
        {
            string selectedColor = ColorBox.SelectedItem.ToString();
            switch (selectedColor)
            {
                case "Красный":
                    currentFactory = new RedFactory();
                    break;
                case "Синий":
                    currentFactory = new BlueFactory();
                    break;
            }
        }
        private void RemoveElements()
        {
            using (Graphics g = DrawPanel.CreateGraphics())
            {
                g.Clear(DrawPanel.BackColor);
            }
        }
        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (FigureBox.SelectedItem == null || ColorBox.SelectedItem == null) return;
            RemoveElements();
            UpdateFactory();
            string? selectedFigure = FigureBox.SelectedItem.ToString();
            using (Graphics g = DrawPanel.CreateGraphics())
            {
                PaintEventArgs pe = new PaintEventArgs(g, DrawPanel.ClientRectangle);
                IShape shape = null;
                switch (selectedFigure)
                {
                    case "Круг":
                        shape = currentFactory.CreateCircle();
                        break;
                    case "Квадрат":
                        shape = currentFactory.CreateSquare();
                        break;
                    case "Треугольник":
                        shape = currentFactory.CreateTriangle();
                        break;
                }
                if (shape != null)
                {
                    shape.Draw(pe);
                }
            }
        }
    }
}
