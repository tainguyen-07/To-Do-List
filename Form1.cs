namespace To_Do_List;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        string task = textBox1.Text.ToString();
        string todaytask = textBox2.Text.ToString();
        string reminder = textBox3.Text.ToString();

        if (checkBox1.Checked)
        {
            listBox1.Items.Add(task);
            if(todaytask == "") {
                listBox1.Items.Add("TODAY");
            }
            else {
                listBox1.Items.Add(todaytask);
            }
        }
        else
        {
            listBox2.Items.Add(reminder);
        }

        textBox1.Clear();
        textBox1.Focus();

        textBox2.Clear();
        textBox2.Focus();

        textBox3.Clear();
        textBox3.Focus();
    }

    private void panel1_Paint(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged
        (object sender, EventArgs e)
    {

    }

    private void button1_Click

        (object sender, EventArgs e)
    {

    }
}