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
    
    public partial class MaterialsOnStorages
    {
        public int Id { get; set; }
        public Nullable<int> IdStorage { get; set; }
        public Nullable<int> IdMaterial { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Storages Storages { get; set; }
    }
}