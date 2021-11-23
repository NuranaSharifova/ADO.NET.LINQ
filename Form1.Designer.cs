
namespace ADO.NET.LINQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.runbutton = new System.Windows.Forms.Button();
            this.creationbutton = new System.Windows.Forms.Button();
            this.fillbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 93);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(760, 319);
            this.datagrid.TabIndex = 0;
            this.datagrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(667, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // runbutton
            // 
            this.runbutton.Location = new System.Drawing.Point(697, 50);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(75, 23);
            this.runbutton.TabIndex = 2;
            this.runbutton.Text = "Run";
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // creationbutton
            // 
            this.creationbutton.Location = new System.Drawing.Point(13, 13);
            this.creationbutton.Name = "creationbutton";
            this.creationbutton.Size = new System.Drawing.Size(151, 23);
            this.creationbutton.TabIndex = 3;
            this.creationbutton.Text = "Create DataBase";
            this.creationbutton.UseVisualStyleBackColor = true;
            this.creationbutton.Click += new System.EventHandler(this.creationbutton_Click);
            // 
            // fillbutton
            // 
            this.fillbutton.Location = new System.Drawing.Point(183, 13);
            this.fillbutton.Name = "fillbutton";
            this.fillbutton.Size = new System.Drawing.Size(153, 23);
            this.fillbutton.TabIndex = 4;
            this.fillbutton.Text = "Fill DataBase";
            this.fillbutton.UseVisualStyleBackColor = true;
            this.fillbutton.Click += new System.EventHandler(this.fillbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillbutton);
            this.Controls.Add(this.creationbutton);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datagrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button runbutton;
        private System.Windows.Forms.Button creationbutton;
        private System.Windows.Forms.Button fillbutton;
        private System.Windows.Forms.Button button1;
    }
}

