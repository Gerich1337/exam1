//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exam1.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phones()
        {
            this.ActsOfBuying = new HashSet<ActsOfBuying>();
        }
    
        public int IdPhone { get; set; }
        public string NamePhone { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Photo { get; set; }
    
        public virtual Types Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActsOfBuying> ActsOfBuying { get; set; }
    }
}
