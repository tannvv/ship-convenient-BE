﻿using ship_convenient.Model.UserModel;
using System.ComponentModel.DataAnnotations;
using unitofwork_core.Constant.Package;
using unitofwork_core.Model.ProductModel;
using PackageEntity = ship_convenient.Entities.Package;

namespace unitofwork_core.Model.PackageModel
{
    public class CreatePackageModel
    {
        public Guid? Id { get; set; }
        public string StartAddress { get; set; } = string.Empty;
        public double StartLongitude { get; set; }
        public double StartLatitude { get; set; }
        public string DestinationAddress { get; set; } = string.Empty;
        public double DestinationLongitude { get; set; }
        public double DestinationLatitude { get; set; }
        public string ReceiverName { get; set; } = string.Empty;
        [Phone]
        public string ReceiverPhone { get; set; } = string.Empty;
        public double Distance { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public int PriceShip { get; set; }
        public string PhotoUrl { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public Guid SenderId { get; set; }
        public List<CreateProductModel> Products { get; set; } = new List<CreateProductModel>();

        public PackageEntity ConverToEntity()
        {
            PackageEntity entity = new PackageEntity();
            if (Id == null || Id == Guid.Empty) {
                Id = new Guid();
            }
            entity.StartAddress = this.StartAddress;
            entity.StartLongitude = this.StartLongitude;
            entity.StartLatitude = this.StartLatitude;
            entity.DestinationAddress = this.DestinationAddress;
            entity.DestinationLongitude = this.DestinationLongitude;
            entity.DestinationLatitude = this.DestinationLatitude;
            entity.Distance = this.Distance;
            entity.Height = this.Height;
            entity.Width = this.Width;
            entity.Length = this.Length;
            entity.Weight = this.Weight;
            entity.ReceiverName = this.ReceiverName;
            entity.ReceiverPhone = this.ReceiverPhone;
            entity.Status = PackageStatus.WAITING;
            entity.PriceShip = this.PriceShip;
            entity.PhotoUrl = this.PhotoUrl;
            entity.Note = this.Note;
            entity.SenderId = this.SenderId;

            int productCount = this.Products.Count;
            for (int i = 0; i < productCount; i++)
            {
                entity.Products.Add(this.Products[i].ConvertToEntity());
            }

            return entity;
        }
    }

}
