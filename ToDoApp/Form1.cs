namespace ToDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text;
            string description = textBox2.Text;

            if (!string.IsNullOrWhiteSpace(taskName))
            {
                checkedListBox1.Items.Add(taskName);
            }

            if (!string.IsNullOrWhiteSpace(description)&& !string.IsNullOrWhiteSpace(taskName))
            {
                textBox3.Text = description;
                
            }


            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = checkedListBox1.SelectedItem.ToString();


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //string description = textBox2.Text;
            //textBox3.Text = description;
        }
    }
}