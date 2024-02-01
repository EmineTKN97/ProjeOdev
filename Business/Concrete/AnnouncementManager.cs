﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }
        [SecuredOperation("ADMİN")]
        [ValidationAspect(typeof(AnnouncementValidator))]
        public async Task<IResult> Add(AnnouncementDTO announcementdto, Guid AdminId)
        {
            _announcementDal.Add(announcementdto,AdminId);
            return new SuccessResult(Messages.AnnouncementAdded);
        }
        [SecuredOperation("ADMİN")]
        public async Task<IResult> Delete(Guid İd, Guid AdminId)
        {
            _announcementDal.Delete(İd,AdminId);
            return new Result(true, Messages.AnnouncementDeleted);
        }

        public async Task<IDataResult<Announcement>> GetById(Guid id)
        {
            return new SuccessDataResult<Announcement>(_announcementDal.Get(ac => ac.Id == id), Messages.AnnouncementListed);
        }

        public async Task<IDataResult<Announcement>> GetLatestAnnouncement()
        {
            return new SuccessDataResult<Announcement>(
                _announcementDal.GetAll().Where(ac => ac.Status == false).OrderByDescending(ac => ac.CreateDate).FirstOrDefault(),
        Messages.AnnouncementListed
            );
        }
        [SecuredOperation("ADMİN")]
        [ValidationAspect(typeof(AnnouncementValidator))]
        public async Task<IResult> Update(Guid id, AnnouncementDTO updatedannouncementdto, Guid AdminId)
        {
            try
            {
                _announcementDal.Update(id, updatedannouncementdto,AdminId);
                return new Result(true, Messages.AnnouncementUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.AnnouncementNotUpdated);
            }
        }
    }
}
