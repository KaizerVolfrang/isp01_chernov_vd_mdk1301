namespace MDK_13_01_Chernov
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Specialtisbutton = new System.Windows.Forms.Button();
            this.GroupsButton = new System.Windows.Forms.Button();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Specialtisbutton
            // 
            this.Specialtisbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Specialtisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Specialtisbutton.Location = new System.Drawing.Point(153, 178);
            this.Specialtisbutton.Name = "Specialtisbutton";
            this.Specialtisbutton.Size = new System.Drawing.Size(124, 50);
            this.Specialtisbutton.TabIndex = 0;
            this.Specialtisbutton.Text = "Специальности";
            this.Specialtisbutton.UseVisualStyleBackColor = false;
            // 
            // GroupsButton
            // 
            this.GroupsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupsButton.Location = new System.Drawing.Point(339, 178);
            this.GroupsButton.Name = "GroupsButton";
            this.GroupsButton.Size = new System.Drawing.Size(126, 50);
            this.GroupsButton.TabIndex = 1;
            this.GroupsButton.Text = "Группы";
            this.GroupsButton.UseVisualStyleBackColor = false;
            // 
            // StudentsButton
            // 
            this.StudentsButton.AutoSize = true;
            this.StudentsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsButton.Location = new System.Drawing.Point(527, 178);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(141, 50);
            this.StudentsButton.TabIndex = 2;
            this.StudentsButton.Text = "Студенты";
            this.StudentsButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentsButton);
            this.Controls.Add(this.GroupsButton);
            this.Controls.Add(this.Specialtisbutton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Specialtisbutton;
        private System.Windows.Forms.Button GroupsButton;
        private System.Windows.Forms.Button StudentsButton;
    }
}

