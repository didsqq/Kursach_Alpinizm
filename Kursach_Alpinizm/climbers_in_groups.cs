//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursach_Alpinizm
{
    using System;
    using System.Collections.Generic;
    
    public partial class climbers_in_groups
    {
        public int ID_entry { get; set; }
        public Nullable<int> ID_alpinist { get; set; }
        public Nullable<int> ID_groups { get; set; }
    
        public virtual alpinists alpinists { get; set; }
        public virtual groups groups { get; set; }
    }
}
