using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class A4GDto : FormDto
    {
        public int? ANYMEDS { get; set; }

        public List<A4DDto> A4Dtos { get; set; }

    }
}

