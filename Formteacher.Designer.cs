namespace School
{
    partial class Formteacher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formteacher));
            System.Windows.Forms.Label код_руководителяLabel;
            System.Windows.Forms.Label фИО_учителяLabel;
            System.Windows.Forms.Label классLabel;
            System.Windows.Forms.Label код_предметаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.schoolDataSet = new School.SchoolDataSet();
            this.учителяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учителяTableAdapter = new School.SchoolDataSetTableAdapters.УчителяTableAdapter();
            this.tableAdapterManager = new School.SchoolDataSetTableAdapters.TableAdapterManager();
            this.учителяBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.учителяBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_руководителяTextBox = new System.Windows.Forms.TextBox();
            this.фИО_учителяTextBox = new System.Windows.Forms.TextBox();
            this.классTextBox = new System.Windows.Forms.TextBox();
            this.код_предметаTextBox = new System.Windows.Forms.TextBox();
            код_руководителяLabel = new System.Windows.Forms.Label();
            фИО_учителяLabel = new System.Windows.Forms.Label();
            классLabel = new System.Windows.Forms.Label();
            код_предметаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingNavigator)).BeginInit();
            this.учителяBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(210, 48);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 20, 120, 20);
            this.label1.Size = new System.Drawing.Size(332, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список учителей";
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учителяBindingSource
            // 
            this.учителяBindingSource.DataMember = "Учителя";
            this.учителяBindingSource.DataSource = this.schoolDataSet;
            // 
            // учителяTableAdapter
            // 
            this.учителяTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = School.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.УченикиTableAdapter = null;
            this.tableAdapterManager.УчителяTableAdapter = this.учителяTableAdapter;
            // 
            // учителяBindingNavigator
            // 
            this.учителяBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.учителяBindingNavigator.BindingSource = this.учителяBindingSource;
            this.учителяBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.учителяBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.учителяBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.учителяBindingNavigatorSaveItem});
            this.учителяBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.учителяBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.учителяBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.учителяBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.учителяBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.учителяBindingNavigator.Name = "учителяBindingNavigator";
            this.учителяBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.учителяBindingNavigator.Size = new System.Drawing.Size(699, 25);
            this.учителяBindingNavigator.TabIndex = 1;
            this.учителяBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // учителяBindingNavigatorSaveItem
            // 
            this.учителяBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.учителяBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("учителяBindingNavigatorSaveItem.Image")));
            this.учителяBindingNavigatorSaveItem.Name = "учителяBindingNavigatorSaveItem";
            this.учителяBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.учителяBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.учителяBindingNavigatorSaveItem.Click += new System.EventHandler(this.учителяBindingNavigatorSaveItem_Click);
            // 
            // код_руководителяLabel
            // 
            код_руководителяLabel.AutoSize = true;
            код_руководителяLabel.BackColor = System.Drawing.Color.Ivory;
            код_руководителяLabel.Location = new System.Drawing.Point(222, 159);
            код_руководителяLabel.Name = "код_руководителяLabel";
            код_руководителяLabel.Size = new System.Drawing.Size(102, 13);
            код_руководителяLabel.TabIndex = 2;
            код_руководителяLabel.Text = "Код руководителя:";
            // 
            // код_руководителяTextBox
            // 
            this.код_руководителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "Код руководителя", true));
            this.код_руководителяTextBox.Location = new System.Drawing.Point(330, 152);
            this.код_руководителяTextBox.Name = "код_руководителяTextBox";
            this.код_руководителяTextBox.Size = new System.Drawing.Size(119, 20);
            this.код_руководителяTextBox.TabIndex = 3;
            // 
            // фИО_учителяLabel
            // 
            фИО_учителяLabel.AutoSize = true;
            фИО_учителяLabel.BackColor = System.Drawing.Color.Ivory;
            фИО_учителяLabel.Location = new System.Drawing.Point(222, 181);
            фИО_учителяLabel.Name = "фИО_учителяLabel";
            фИО_учителяLabel.Size = new System.Drawing.Size(79, 13);
            фИО_учителяLabel.TabIndex = 4;
            фИО_учителяLabel.Text = "ФИО учителя:";
            // 
            // фИО_учителяTextBox
            // 
            this.фИО_учителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "ФИО учителя", true));
            this.фИО_учителяTextBox.Location = new System.Drawing.Point(307, 178);
            this.фИО_учителяTextBox.Name = "фИО_учителяTextBox";
            this.фИО_учителяTextBox.Size = new System.Drawing.Size(142, 20);
            this.фИО_учителяTextBox.TabIndex = 5;
            // 
            // классLabel
            // 
            классLabel.AutoSize = true;
            классLabel.BackColor = System.Drawing.Color.Ivory;
            классLabel.Location = new System.Drawing.Point(222, 204);
            классLabel.Name = "классLabel";
            классLabel.Size = new System.Drawing.Size(41, 13);
            классLabel.TabIndex = 6;
            классLabel.Text = "Класс:";
            // 
            // классTextBox
            // 
            this.классTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "Класс", true));
            this.классTextBox.Location = new System.Drawing.Point(269, 204);
            this.классTextBox.Name = "классTextBox";
            this.классTextBox.Size = new System.Drawing.Size(180, 20);
            this.классTextBox.TabIndex = 7;
            // 
            // код_предметаLabel
            // 
            код_предметаLabel.AutoSize = true;
            код_предметаLabel.BackColor = System.Drawing.Color.Ivory;
            код_предметаLabel.Location = new System.Drawing.Point(222, 233);
            код_предметаLabel.Name = "код_предметаLabel";
            код_предметаLabel.Size = new System.Drawing.Size(81, 13);
            код_предметаLabel.TabIndex = 8;
            код_предметаLabel.Text = "Код предмета:";
            // 
            // код_предметаTextBox
            // 
            this.код_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учителяBindingSource, "Код предмета", true));
            this.код_предметаTextBox.Location = new System.Drawing.Point(307, 230);
            this.код_предметаTextBox.Name = "код_предметаTextBox";
            this.код_предметаTextBox.Size = new System.Drawing.Size(142, 20);
            this.код_предметаTextBox.TabIndex = 9;
            // 
            // Formteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(код_предметаLabel);
            this.Controls.Add(this.код_предметаTextBox);
            this.Controls.Add(классLabel);
            this.Controls.Add(this.классTextBox);
            this.Controls.Add(фИО_учителяLabel);
            this.Controls.Add(this.фИО_учителяTextBox);
            this.Controls.Add(код_руководителяLabel);
            this.Controls.Add(this.код_руководителяTextBox);
            this.Controls.Add(this.учителяBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Formteacher";
            this.Text = "Formteacher";
            this.Load += new System.EventHandler(this.Formteacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учителяBindingNavigator)).EndInit();
            this.учителяBindingNavigator.ResumeLayout(false);
            this.учителяBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource учителяBindingSource;
        private SchoolDataSetTableAdapters.УчителяTableAdapter учителяTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator учителяBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton учителяBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_руководителяTextBox;
        private System.Windows.Forms.TextBox фИО_учителяTextBox;
        private System.Windows.Forms.TextBox классTextBox;
        private System.Windows.Forms.TextBox код_предметаTextBox;
    }
}