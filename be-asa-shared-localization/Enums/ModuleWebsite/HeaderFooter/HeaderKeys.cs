using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_asa_shared_localization.Enums.ModuleWebsite.HeaderFooter
{
    public enum HeaderKeys
    {
        
        HEADER_NOT_FOUND,

       
        INVALID_HEADER_ID,
        INVALID_PARENT_ID,
        INVALID_PAGE_INDEX,
        INVALID_PAGE_SIZE,
        INVALID_HEADER_LIST,
        INVALID_CREATE_REQUEST,
        INVALID_UPDATE_REQUEST,

      
        HEADER_NAME_REQUIRED,
        HEADER_CODE_REQUIRED,

   
        HEADER_CODE_EXISTS,
        PARENT_HEADER_NOT_FOUND,
        HEADERS_NOT_FOUND,

      
        CANNOT_SET_SELF_AS_PARENT,
        CIRCULAR_REFERENCE_ERROR,
        CANNOT_DELETE_HEADER_WITH_CHILDREN,

     
        USER_NOT_AUTHENTICATED,

        
        GET_MENU_TREE_ERROR,
        GET_PAGINATED_HEADERS_ERROR,
        GET_ALL_HEADERS_ERROR,
        GET_CHILD_HEADERS_ERROR,
        GET_HEADER_BY_ID_ERROR,
        CREATE_HEADER_ERROR,
        UPDATE_HEADER_ERROR,
        DELETE_HEADER_ERROR,
        BUILD_TREE_ERROR,
        PAGINATION_ERROR,
        URL_REQUIRED,
        URL_EXISTS
    }
}
