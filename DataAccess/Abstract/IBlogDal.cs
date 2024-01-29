﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
        List<BlogDetailsDTO> GetBlogsByCommentAndLikeCount();
        void Delete(Guid id);
        void Update(Guid id, BlogDTO updatedBlogDto);
        void Add(BlogDTO blogdto);
        List<Blog> GetByUserId(Guid userId);
    }
}