//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DE.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AgentId { get; set; }
        public System.DateTime Date { get; set; }
        public int CountProduct { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Product Product { get; set; }
    }
}