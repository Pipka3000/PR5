//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR5
{
    using System;
    using System.Collections.Generic;
    
    public partial class @class
    {
        public int class_id { get; set; }
        public Nullable<int> classroom_ids { get; set; }
        public Nullable<int> student_ids { get; set; }
        public Nullable<int> year_study { get; set; }
        public string name_class { get; set; }
    
        public virtual classroom classroom { get; set; }
        public virtual student student { get; set; }
    }
}