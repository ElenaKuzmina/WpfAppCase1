//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppCase1.Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class PointOfSale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PointOfSale()
        {
            this.OpeningHour = new HashSet<OpeningHour>();
            this.TrafficPaht = new HashSet<TrafficPaht>();
        }
    
        public int Id { get; set; }
        public string Address { get; set; }
        public Nullable<int> Warehouse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningHour> OpeningHour { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrafficPaht> TrafficPaht { get; set; }
    }
}
