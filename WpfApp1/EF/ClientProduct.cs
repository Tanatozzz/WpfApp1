//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientProduct
    {
        public int ID { get; set; }
        public int IDClient { get; set; }
        public int IDStaff { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public int IDProduct { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
        public virtual Employee Employee { get; set; }
    }
}