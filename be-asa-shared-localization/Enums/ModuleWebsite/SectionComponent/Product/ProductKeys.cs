using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_asa_shared_localization.Enums.ModuleWebsite.SectionComponent.Product
{
    public enum ProductKeys
    {

        NOT_FOUND,
        MAIN_NOT_FOUND,


        INVALID_REQUEST,
        INVALID_PRODUCT_ID,
        INVALID_PRODUCT_NAME,
        PRODUCT_NAME_TOO_LONG,
        PRODUCT_DESCRIPTION_TOO_LONG,
        INVALID_PAGE_INDEX,
        INVALID_PAGE_SIZE,
        INVALID_MAIN_IMAGE_INDEX,
        INVALID_IMAGE_FILE,
        INVALID_DOWNLOAD_TITLE,
        INVALID_DOWNLOAD_FILE,
        INVALID_FEATURE_TITLE,


        USER_NOT_AUTHORIZED,


        CONTACT_NOT_FOUND,
        CANNOT_DELETE_MAIN_PRODUCT,


        SAVE_IMAGE_ERROR,
        SAVE_FEATURE_IMAGE_ERROR,


        GET_PRODUCTS_ERROR,
        GET_LANDING_PRODUCTS_ERROR,
        GET_PRODUCT_ERROR,
        CREATE_PRODUCT_ERROR,
        UPDATE_PRODUCT_ERROR,
        DELETE_PRODUCT_ERROR,
        GET_HIGHLIGHTED_PRODUCTS_ERROR,
        GET_MAIN_PRODUCT_ERROR,

        TEMPLATE_NOT_FOUND,
        FEATURE_NOT_FOUND
    }
}
