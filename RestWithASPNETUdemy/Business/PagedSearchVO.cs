using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public class PagedSearchVO<T>
    {
        public int CurrentPage { get; internal set; }
        public List<PersonVO> List { get; internal set; }
        public int PageSize { get; internal set; }
        public string SortDirections { get; internal set; }
        public int TotalResults { get; internal set; }
    }
}