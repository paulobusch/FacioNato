namespace AppFacioNato.CadPeople.View
{
    partial class FormCadPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadPeople));
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxCadInquilinoInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPlusBadroom = new System.Windows.Forms.Button();
            this.cbxBedroom = new System.Windows.Forms.ComboBox();
            this.lblBedroom = new System.Windows.Forms.Label();
            this.cbxPeriod = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.lblCouse = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBoxCadInquilinoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxCadInquilinoInfo
            // 
            this.groupBoxCadInquilinoInfo.Controls.Add(this.btnCancel);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.btnPlusBadroom);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.cbxBedroom);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblBedroom);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.cbxPeriod);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.btnSave);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblPeriod);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.cbxCourse);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.cbxCity);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblCouse);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblCity);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.txtName);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblName);
            this.groupBoxCadInquilinoInfo.Location = new System.Drawing.Point(21, 26);
            this.groupBoxCadInquilinoInfo.Name = "groupBoxCadInquilinoInfo";
            this.groupBoxCadInquilinoInfo.Size = new System.Drawing.Size(468, 342);
            this.groupBoxCadInquilinoInfo.TabIndex = 3;
            this.groupBoxCadInquilinoInfo.TabStop = false;
            this.groupBoxCadInquilinoInfo.Text = "Informações Cadastrais";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::WindowsFormsPrototipo.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(265, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnCancel.Size = new System.Drawing.Size(163, 74);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPlusBadroom
            // 
            this.btnPlusBadroom.AutoSize = true;
            this.btnPlusBadroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusBadroom.Image = global::WindowsFormsPrototipo.Properties.Resources.plus;
            this.btnPlusBadroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlusBadroom.Location = new System.Drawing.Point(408, 186);
            this.btnPlusBadroom.Name = "btnPlusBadroom";
            this.btnPlusBadroom.Size = new System.Drawing.Size(33, 31);
            this.btnPlusBadroom.TabIndex = 13;
            this.btnPlusBadroom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlusBadroom.UseVisualStyleBackColor = true;
            // 
            // cbxBedroom
            // 
            this.cbxBedroom.FormattingEnabled = true;
            this.cbxBedroom.Location = new System.Drawing.Point(306, 190);
            this.cbxBedroom.Name = "cbxBedroom";
            this.cbxBedroom.Size = new System.Drawing.Size(96, 24);
            this.cbxBedroom.TabIndex = 12;
            // 
            // lblBedroom
            // 
            this.lblBedroom.AutoSize = true;
            this.lblBedroom.Location = new System.Drawing.Point(238, 193);
            this.lblBedroom.Name = "lblBedroom";
            this.lblBedroom.Size = new System.Drawing.Size(56, 17);
            this.lblBedroom.TabIndex = 11;
            this.lblBedroom.Text = "Quarto:";
            // 
            // cbxPeriod
            // 
            this.cbxPeriod.FormattingEnabled = true;
            this.cbxPeriod.Location = new System.Drawing.Point(98, 190);
            this.cbxPeriod.Name = "cbxPeriod";
            this.cbxPeriod.Size = new System.Drawing.Size(112, 24);
            this.cbxPeriod.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsPrototipo.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(70, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10);
            this.btnSave.Size = new System.Drawing.Size(157, 74);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Gravar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(21, 193);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(61, 17);
            this.lblPeriod.TabIndex = 9;
            this.lblPeriod.Text = "Período:";
            // 
            // cbxCourse
            // 
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(98, 140);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(343, 24);
            this.cbxCourse.TabIndex = 8;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(98, 92);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(343, 24);
            this.cbxCity.TabIndex = 7;
            // 
            // lblCouse
            // 
            this.lblCouse.AutoSize = true;
            this.lblCouse.Location = new System.Drawing.Point(33, 143);
            this.lblCouse.Name = "lblCouse";
            this.lblCouse.Size = new System.Drawing.Size(49, 17);
            this.lblCouse.TabIndex = 5;
            this.lblCouse.Text = "Curso:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(26, 95);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 17);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Cidade:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(343, 22);
            this.txtName.TabIndex = 2;
            // 
            // FormCadPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 387);
            this.Controls.Add(this.groupBoxCadInquilinoInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadPeople";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Inquilino";
            this.groupBoxCadInquilinoInfo.ResumeLayout(false);
            this.groupBoxCadInquilinoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBoxCadInquilinoInfo;
        private System.Windows.Forms.ComboBox cbxBedroom;
        private System.Windows.Forms.Label lblBedroom;
        private System.Windows.Forms.ComboBox cbxPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label lblCouse;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPlusBadroom;
        private System.Windows.Forms.Button btnCancel;
    }
}

