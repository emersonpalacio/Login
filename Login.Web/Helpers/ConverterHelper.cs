using Login.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Common.Models;

namespace Login.Web.Helpers
{
    public class ConverterHelper:IConverterHelper
    {
        public TripResponse ToTripResponse(TripEntity tripEntity)
        {
            return new TripResponse
            {
                EndDate = tripEntity.EndDate,
                Id = tripEntity.Id,
                Qualification = tripEntity.Qualification,
                Remarks = tripEntity.Remarks,
                Source = tripEntity.Source,
                SourceLatitude = tripEntity.SourceLatitude,
                SourceLongitude = tripEntity.SourceLongitude,
                StartDate = tripEntity.StartDate,
                Target = tripEntity.Target,
                TargetLatitude = tripEntity.TargetLatitude,
                TargetLongitude = tripEntity.TargetLongitude,
                TripDetails = tripEntity.TripDetails?.Select(td => new TripDetailResponse
                {
                    Date = td.Date,
                    Id = td.Id,
                    Latitude = td.Latitude,
                    Longitude = td.Longitude
                }).ToList(),
                User = ToUserResponse(tripEntity.User)
            };
        }

        private UserResponse ToUserResponse(UserEntity user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserResponse
            {
                Address = user.Address,
                Document = user.Document,
                Email = user.Email,
                FirstName = user.FirstName,
                Id = user.Id,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                PicturePath = user.PicturePath,
                UserType = user.UserType
            };
        }
    }
}
