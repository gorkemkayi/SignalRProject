using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.BookingDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.FeatureDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.DAL.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            #region About Mapping
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            #endregion

            #region Booking Mapping
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            #endregion

            #region Category Mapping
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            #endregion


            #region Contact Mapping
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            #endregion

            #region Discount Mapping
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<CreateDiscountDto, Discount>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            #endregion

            #region Feature Mapping
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<CreateFeatureDto, Feature>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            #endregion

            #region Product Mapping
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            #endregion

            #region SocialMedia Mapping
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            #endregion

            #region Testimonial Mapping
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            #endregion
        }
    }
}
