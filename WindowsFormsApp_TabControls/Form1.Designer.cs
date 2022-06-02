
namespace WindowsFormsApp_TabControls
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.first_tab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.second_tab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.first_tab.SuspendLayout();
            this.second_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.first_tab);
            this.tabControl1.Controls.Add(this.second_tab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(36, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 418);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // first_tab
            // 
            this.first_tab.Controls.Add(this.label1);
            this.first_tab.Location = new System.Drawing.Point(4, 26);
            this.first_tab.Name = "first_tab";
            this.first_tab.Padding = new System.Windows.Forms.Padding(3);
            this.first_tab.Size = new System.Drawing.Size(705, 388);
            this.first_tab.TabIndex = 0;
            this.first_tab.Text = "First Tab";
            this.first_tab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is First Tab ";
            // 
            // second_tab
            // 
            this.second_tab.Controls.Add(this.label2);
            this.second_tab.Location = new System.Drawing.Point(4, 26);
            this.second_tab.Name = "second_tab";
            this.second_tab.Padding = new System.Windows.Forms.Padding(3);
            this.second_tab.Size = new System.Drawing.Size(705, 388);
            this.second_tab.TabIndex = 1;
            this.second_tab.Text = "Second Tab";
            this.second_tab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "This is Second Tab";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.first_tab.ResumeLayout(false);
            this.first_tab.PerformLayout();
            this.second_tab.ResumeLayout(false);
            this.second_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage first_tab;
        private System.Windows.Forms.TabPage second_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

