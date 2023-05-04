namespace ListBox_sport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            text_time.Text = now.ToString("HH:mm:ss");
            text_date.Text = now.ToString("dd/MM/yyyy");
        }

        private void BTN_Add_All_Click(object sender, EventArgs e)
        {
            list_chose.Items.AddRange(list_Play1.Items);
            list_Play1.Items.Clear();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            list_chose.Items.Add(list_Play1.SelectedItem);
            list_Play1.Items.Remove(list_Play1.SelectedItem);
        }

        private void BTN_Sub_All_Click(object sender, EventArgs e)
        {
            list_Play1.Items.AddRange(list_chose.Items);
            list_chose.Items.Clear();
        }

        private void BTN_Sub_Click(object sender, EventArgs e)
        {
            list_Play1.Items.Add(list_chose.SelectedItem);
            list_chose.Items.Remove(list_chose.SelectedItem);
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            if (comboBox_input.Text != "")
            {
                comboBox_input.Items.Add(comboBox_input.Text);
                richTextBox_output.Text += comboBox_input.Text + "\n" + text_date.Text + " " + text_time.Text + "\n ** Món đã chọn:\n";
                for (int i = 0; i < list_chose.Items.Count; i++)
                {
                    richTextBox_output.Text += list_chose.Items[i].ToString();
                }

            }
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            
        }
    }
}