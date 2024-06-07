namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримати значення з текстових полів
                double a = Convert.ToDouble(txtCubeSide.Text);
                double c = Convert.ToDouble(txtRectLength.Text);
                double d = Convert.ToDouble(txtRectWidth.Text);
                double h = Convert.ToDouble(txtRectHeight.Text);

                // Створити об'єкти для куба та прямокутного паралелепіпеда
                Solid cube = new Cube(a);
                Solid rectSolid = new RectSolid(c, d, h);

                // Обчислити об'єми
                double cubeVolume = cube.GetVolume();
                double rectVolume = rectSolid.GetVolume();

                // Вивести результати
                txtCubeVolume.Text = cubeVolume.ToString();
                txtRectVolume.Text = rectVolume.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
