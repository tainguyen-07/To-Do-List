namespace To_Do_List;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        flowLayoutPanel1 = new FlowLayoutPanel();
        panel1 = new Panel();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        button5 = new Button();
        button6 = new Button();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        listBox1 = new ListBox();
        listBox2 = new ListBox();
        checkBox1 = new CheckBox();
        flowLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(panel1);
        flowLayoutPanel1.Controls.Add(button2);
        flowLayoutPanel1.Controls.Add(button3);
        flowLayoutPanel1.Controls.Add(button4);
        flowLayoutPanel1.Location = new Point(0, 1);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(204, 437);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(201, 97);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(0, 0);
        button1.Name = "button1";
        button1.Size = new Size(201, 97);
        button1.TabIndex = 0;
        button1.Text = "HOME";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(3, 106);
        button2.Name = "button2";
        button2.Size = new Size(201, 97);
        button2.TabIndex = 1;
        button2.Text = "TODO";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(3, 209);
        button3.Name = "button3";
        button3.Size = new Size(201, 97);
        button3.TabIndex = 2;
        button3.Text = "SCHEDULE";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(3, 312);
        button4.Name = "button4";
        button4.Size = new Size(201, 97);
        button4.TabIndex = 3;
        button4.Text = "TODAY";
        button4.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(240, 44);
        label1.Name = "label1";
        label1.Size = new Size(43, 20);
        label1.TabIndex = 1;
        label1.Text = "TASK";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(240, 145);
        label2.Name = "label2";
        label2.Size = new Size(38, 20);
        label2.TabIndex = 2;
        label2.Text = "DUE";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(240, 248);
        label3.Name = "label3";
        label3.Size = new Size(81, 20);
        label3.TabIndex = 3;
        label3.Text = "SCHEDULE";
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(240, 351);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 4;
        label4.Text = "DUE TODAY";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(509, 351);
        label5.Name = "label5";
        label5.Size = new Size(54, 20);
        label5.TabIndex = 5;
        label5.Text = "REMIN";
        // 
        // button5
        // 
        button5.Location = new Point(694, 35);
        button5.Name = "button5";
        button5.Size = new Size(94, 29);
        button5.TabIndex = 6;
        button5.Text = "ADD";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(694, 141);
        button6.Name = "button6";
        button6.Size = new Size(94, 29);
        button6.TabIndex = 7;
        button6.Text = "DELETE";
        button6.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(426, 39);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 8;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(426, 138);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 9;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(426, 241);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(125, 27);
        textBox3.TabIndex = 10;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(334, 313);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(150, 104);
        listBox1.TabIndex = 11;
        // 
        // listBox2
        // 
        listBox2.FormattingEnabled = true;
        listBox2.Location = new Point(638, 313);
        listBox2.Name = "listBox2";
        listBox2.Size = new Size(150, 104);
        listBox2.TabIndex = 12;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(427, 185);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(69, 24);
        checkBox1.TabIndex = 13;
        checkBox1.Text = "urgen";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(checkBox1);
        Controls.Add(listBox2);
        Controls.Add(listBox1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(flowLayoutPanel1);
        Name = "Form1";
        Text = "To Do List";
        flowLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private Panel panel1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Button button5;
    private Button button6;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private ListBox listBox1;
    private ListBox listBox2;
    private CheckBox checkBox1;
}
