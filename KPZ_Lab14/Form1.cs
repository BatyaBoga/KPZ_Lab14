

namespace KPZ_Lab14
{
    public partial class Form1 : Form
    {

        int[] mass;

        Random rnd;

        Sort sort;

        public Form1()
        {
            InitializeComponent();

            mass = new int[50];

            rnd = new Random();

            sort = new Sort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           FillMass();
        }

        private void FillMass()
        {
            textBox2.Text = textBox3.Text = textBox1.Text = String.Empty;

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 50);

                textBox1.Text += mass[i].ToString() + " ";

                textBox2.Text = textBox3.Text = textBox1.Text;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
 
            textBox1.Text = MassToString(await sort.InsertionSortAsync(mass));
            textBox2.Text = MassToString(await sort.SelectionSortAsync(mass));
            textBox3.Text = MassToString(await sort.BubbleSortAsync(mass));
        }

        private string MassToString(int[] mass)
        {
            string res = String.Empty;


            foreach (var item in mass)
            {
                res += item.ToString() + " ";
            }

            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillMass();
        }
    }
}