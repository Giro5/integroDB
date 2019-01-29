namespace integroDB
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кабинетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриемаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видОказываемыхУслугDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоВрачаDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.врачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоматологияDataSet = new integroDB.стоматологияDataSet();
            this.стоматологияDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.врачи_выборкаTableAdapter1 = new integroDB.стоматологияDataSetTableAdapters.Врачи_выборкаTableAdapter();
            this.врачиTableAdapter = new integroDB.стоматологияDataSetTableAdapters.ВрачиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new integroDB.стоматологияDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВрачаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.кабинетаDataGridViewTextBoxColumn,
            this.времяПриемаDataGridViewTextBoxColumn,
            this.видОказываемыхУслугDataGridViewTextBoxColumn,
            this.фотоВрачаDataGridViewImageColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.врачиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1084, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDВрачаDataGridViewTextBoxColumn
            // 
            this.iDВрачаDataGridViewTextBoxColumn.DataPropertyName = "ID врача";
            this.iDВрачаDataGridViewTextBoxColumn.HeaderText = "ID врача";
            this.iDВрачаDataGridViewTextBoxColumn.Name = "iDВрачаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // кабинетаDataGridViewTextBoxColumn
            // 
            this.кабинетаDataGridViewTextBoxColumn.DataPropertyName = "№ кабинета";
            this.кабинетаDataGridViewTextBoxColumn.HeaderText = "№ кабинета";
            this.кабинетаDataGridViewTextBoxColumn.Name = "кабинетаDataGridViewTextBoxColumn";
            // 
            // времяПриемаDataGridViewTextBoxColumn
            // 
            this.времяПриемаDataGridViewTextBoxColumn.DataPropertyName = "Время приема";
            this.времяПриемаDataGridViewTextBoxColumn.HeaderText = "Время приема";
            this.времяПриемаDataGridViewTextBoxColumn.Name = "времяПриемаDataGridViewTextBoxColumn";
            // 
            // видОказываемыхУслугDataGridViewTextBoxColumn
            // 
            this.видОказываемыхУслугDataGridViewTextBoxColumn.DataPropertyName = "Вид оказываемых услуг";
            this.видОказываемыхУслугDataGridViewTextBoxColumn.HeaderText = "Вид оказываемых услуг";
            this.видОказываемыхУслугDataGridViewTextBoxColumn.Name = "видОказываемыхУслугDataGridViewTextBoxColumn";
            // 
            // фотоВрачаDataGridViewImageColumn
            // 
            this.фотоВрачаDataGridViewImageColumn.DataPropertyName = "Фото врача";
            this.фотоВрачаDataGridViewImageColumn.HeaderText = "Фото врача";
            this.фотоВрачаDataGridViewImageColumn.Name = "фотоВрачаDataGridViewImageColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // врачиBindingSource
            // 
            this.врачиBindingSource.DataMember = "Врачи";
            this.врачиBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // стоматологияDataSet
            // 
            this.стоматологияDataSet.DataSetName = "стоматологияDataSet";
            this.стоматологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стоматологияDataSetBindingSource
            // 
            this.стоматологияDataSetBindingSource.DataSource = this.стоматологияDataSet;
            this.стоматологияDataSetBindingSource.Position = 0;
            // 
            // врачи_выборкаTableAdapter1
            // 
            this.врачи_выборкаTableAdapter1.ClearBeforeFill = true;
            // 
            // врачиTableAdapter
            // 
            this.врачиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = integroDB.стоматологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВрачиTableAdapter = this.врачиTableAdapter;
            this.tableAdapterManager.ЖурналTableAdapter = null;
            this.tableAdapterManager.НаименованиеУслугTableAdapter = null;
            this.tableAdapterManager.Смена_подстановкаTableAdapter = null;
            this.tableAdapterManager.СписокПациентовTableAdapter = null;
            this.tableAdapterManager.Услуги_подстановкаTableAdapter = null;
            this.tableAdapterManager.Штатное_расписаниеTableAdapter = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Integration Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource стоматологияDataSetBindingSource;
        private стоматологияDataSet стоматологияDataSet;
        private стоматологияDataSetTableAdapters.Врачи_выборкаTableAdapter врачи_выборкаTableAdapter1;
        private System.Windows.Forms.BindingSource врачиBindingSource;
        private стоматологияDataSetTableAdapters.ВрачиTableAdapter врачиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кабинетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриемаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видОказываемыхУслугDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоВрачаDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private стоматологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

