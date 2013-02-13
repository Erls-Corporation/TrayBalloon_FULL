namespace TrayBaloonTest
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this._Show = new System.Windows.Forms.Button();
            this._Title = new System.Windows.Forms.TextBox();
            this._Text = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 13);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 13);
            label2.TabIndex = 3;
            label2.Text = "Text";
            // 
            // _Show
            // 
            this._Show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._Show.Location = new System.Drawing.Point(12, 210);
            this._Show.Name = "_Show";
            this._Show.Size = new System.Drawing.Size(267, 23);
            this._Show.TabIndex = 0;
            this._Show.Text = "Show";
            this._Show.UseVisualStyleBackColor = true;
            this._Show.Click += new System.EventHandler(this._Show_Click);
            // 
            // _Title
            // 
            this._Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._Title.Location = new System.Drawing.Point(12, 25);
            this._Title.Name = "_Title";
            this._Title.Size = new System.Drawing.Size(267, 20);
            this._Title.TabIndex = 2;
            this._Title.Text = "Hello CodeProject";
            // 
            // _Text
            // 
            this._Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._Text.Location = new System.Drawing.Point(12, 78);
            this._Text.Multiline = true;
            this._Text.Name = "_Text";
            this._Text.Size = new System.Drawing.Size(267, 126);
            this._Text.TabIndex = 4;
            this._Text.Text = "Please visit <a href=\"http://www.codeproject.com\">CodeProject</a> to learn more.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 245);
            this.Controls.Add(this._Text);
            this.Controls.Add(label2);
            this.Controls.Add(this._Title);
            this.Controls.Add(label1);
            this.Controls.Add(this._Show);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrayBaloon Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _Show;
        private System.Windows.Forms.TextBox _Title;
        private System.Windows.Forms.TextBox _Text;
    }
}

