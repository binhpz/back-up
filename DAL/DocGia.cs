using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DocGia
    {
        [Key]
        public long MaDG { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgayHetHanThe { get; set; }

        public string SoCMT { get; set; }

        public string SDT { get; set; }

        public string DiaChi { get; set; }
    }
}
