using Henry_Inc.Data.Contexts;
using Henry_Inc.Data.Entities;
using Henry_Inc.ViewModels.System.Roles;
using Henry_Inc.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henry_Inc.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly MyAppContext _context;

        public SlideService(MyAppContext context)
        {
            _context = context;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image,
                    Status = x.Status
                }).ToListAsync();

            return slides;
        }
    }
}
