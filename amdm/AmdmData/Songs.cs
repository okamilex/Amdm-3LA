//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmdmData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Songs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Songs()
        {
            this.Chords = new HashSet<Chords>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string SongPageLink { get; set; }
        public string Text { get; set; }
        public int Views { get; set; }
        public string VideoLink { get; set; }
        public Nullable<int> PerformerId { get; set; }
    
        public virtual Performers Performers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chords> Chords { get; set; }
    }
}