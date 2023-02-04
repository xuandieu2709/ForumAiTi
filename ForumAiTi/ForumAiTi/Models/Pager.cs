using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class Pager
    {
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }

        public int PageSize { get; private set; }

        public int TotalPages { get; private set; }

        public int StartPage { get; private set; }

        public int EndPage { get; private set; }
        public Pager()
        { }
        public Pager(int totalItems, int page, int pageSize = 10)
        {
            // total = 6, page = 2 , pagesize = 5
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            Console.WriteLine("total page" + totalPages);
            int currentPage = page;
            int startPage = 1;
            int endPage = currentPage + startPage;
            if (endPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }
            if (endPage > totalPages)
            {
                endPage = totalPages;
                if (endPage >= 10)
                {
                    startPage = endPage - 9;
                }
            }
            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
        }

    }
}