namespace AppFacioNato.CadRecurrence.View
{
    partial class FormConfRecurrence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfRecurrence));
            this.groupBoxCadInquilinoInfo = new System.Windows.Forms.GroupBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCadInquilinoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadInquilinoInfo
            // 
            this.groupBoxCadInquilinoInfo.Controls.Add(this.dtpFirstDate);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblFirstDate);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.cbxType);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblType);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.btnCancel);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.button2);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.txtValue);
            this.groupBoxCadInquilinoInfo.Controls.Add(this.lblValue);
            this.groupBoxCadInquilinoInfo.Location = new System.Drawing.Point(23, 70);
            this.groupBoxCadInquilinoInfo.Name = "groupBoxCadInquilinoInfo";
            this.groupBoxCadInquilinoInfo.Size = new System.Drawing.Size(448, 322);
            this.groupBoxCadInquilinoInfo.TabIndex = 5;
            this.groupBoxCadInquilinoInfo.TabStop = false;
            this.groupBoxCadInquilinoInfo.Text = "Informações de Cobrança";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(264, 49);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(146, 24);
            this.cbxType.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(209, 52);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Tipo:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::WindowsFormsPrototipo.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(247, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnCancel.Size = new System.Drawing.Size(163, 74);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsPrototipo.Properties.Resources.save;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(49, 223);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(157, 74);
            this.button2.TabIndex = 0;
            this.button2.Text = "Gravar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(107, 49);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(82, 22);
            this.txtValue.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(47, 52);
            this.lblValue.Name = "lblValue";
            this.lblValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValue.Size = new System.Drawing.Size(45, 17);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Valor:";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(23, 22);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(215, 21);
            this.chkEnable.TabIndex = 6;
            this.chkEnable.Text = "Habilitar cobrança de aluguel";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Location = new System.Drawing.Point(69, 122);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstDate.Size = new System.Drawing.Size(180, 17);
            this.lblFirstDate.TabIndex = 18;
            this.lblFirstDate.Text = "Data da primeira cobrança:";
            this.lblFirstDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFirstDate.Location = new System.Drawing.Point(264, 117);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(146, 22);
            this.dtpFirstDate.TabIndex = 19;
            // 
            // FormConfRecurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 416);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.groupBoxCadInquilinoInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfRecurrence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Cobrança Recorrente";
            this.groupBoxCadInquilinoInfo.ResumeLayout(false);
            this.groupBoxCadInquilinoInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadInquilinoInfo;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.Label lblFirstDate;
    }
}