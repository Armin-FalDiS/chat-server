namespace AFDChatClient
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
            this.bSend = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.tSend = new System.Windows.Forms.TextBox();
            this.userList = new System.Windows.Forms.ListBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(656, 495);
            this.bSend.Margin = new System.Windows.Forms.Padding(6);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(82, 65);
            this.bSend.TabIndex = 1;
            this.bSend.TabStop = false;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(15, 15);
            this.chatBox.Margin = new System.Windows.Forms.Padding(6);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(624, 468);
            this.chatBox.TabIndex = 2;
            this.chatBox.TabStop = false;
            this.chatBox.Text = "";
            // 
            // tSend
            // 
            this.tSend.AcceptsReturn = true;
            this.tSend.Location = new System.Drawing.Point(15, 495);
            this.tSend.MaxLength = 1000;
            this.tSend.Multiline = true;
            this.tSend.Name = "tSend";
            this.tSend.Size = new System.Drawing.Size(624, 65);
            this.tSend.TabIndex = 0;
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 25;
            this.userList.Location = new System.Drawing.Point(648, 15);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(153, 454);
            this.userList.TabIndex = 4;
            this.userList.TabStop = false;
            // 
            // bRefresh
            // 
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRefresh.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bRefresh.Location = new System.Drawing.Point(747, 495);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(54, 67);
            this.bRefresh.TabIndex = 5;
            this.bRefresh.Text = "↻";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 567);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.tSend);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.bSend);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox tSend;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button bRefresh;
    }
}

