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
        this.Label0 = new System.Windows.Forms.Label();
        this.Button2 = new System.Windows.Forms.Button();
        this.Button3 = new System.Windows.Forms.Button();
        this.Button4 = new System.Windows.Forms.Button();
        this.TextBox6 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        //
        // Label0
        //
        this.Label0.AutoSize =  true;
        this.Label0.Text =  "Task";
        this.Label0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.Label0.Location = new System.Drawing.Point(32,20);
        this.Label0.Size = new System.Drawing.Size(47,25);
        //
        // Button2
        //
        this.Button2.Text =  "Add";
        this.Button2.Location = new System.Drawing.Point(40,84);
        this.Button2.Size = new System.Drawing.Size(80,28);
        this.Button2.TabIndex = 2;
        //
        // Button3
        //
        this.Button3.Text =  "Edit";
        this.Button3.Location = new System.Drawing.Point(136,84);
        this.Button3.Size = new System.Drawing.Size(80,28);
        this.Button3.TabIndex = 3;
        //
        // Button4
        //
        this.Button4.Text =  "Delete";
        this.Button4.Location = new System.Drawing.Point(232,84);
        this.Button4.Size = new System.Drawing.Size(80,28);
        this.Button4.TabIndex = 4;
        //
        // TextBox6
        //
        this.TextBox6.Modified =  true;
        this.TextBox6.Location = new System.Drawing.Point(40,48);
        this.TextBox6.Size = new System.Drawing.Size(396,23);
        this.TextBox6.TabIndex = 6;
        //
        //  Form
        //
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "To Do List";
        this.Controls.Add(this.Label0);
        this.Controls.Add(this.Button2);
        this.Controls.Add(this.Button3);
        this.Controls.Add(this.Button4);
        this.Controls.Add(this.TextBox6);
    }

    #endregion

     private System.Windows.Forms.Label Label0;
    private System.Windows.Forms.Button Button2;
    private System.Windows.Forms.Button Button3;
    private System.Windows.Forms.Button Button4;
    private System.Windows.Forms.TextBox TextBox6;
}
