//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Товары
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Товары()
        {
            this.ЗаказанныеТовары = new HashSet<ЗаказанныеТовары>();
        }
    
        public int ID_товара { get; set; }
        public string Наименование_товара { get; set; }
        public Nullable<int> Количество_на_складе { get; set; }
        public Nullable<decimal> Цена_за_единицу_товара { get; set; }
        public Nullable<int> ID_поставщика { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаказанныеТовары> ЗаказанныеТовары { get; set; }
        public virtual Поставщики Поставщики { get; set; }
    }
}
