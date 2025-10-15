namespace be_asa_shared_localization.Enums.ModuleWebsite.Page
{
    public enum ArticleCategoryKeys
    {
        NOT_FOUND,                     // Khi không tìm thấy danh mục
        NAME_ALREADY_EXISTS,           // Khi tên danh mục đã tồn tại
        CATEGORY_IN_USE_CANNOT_DELETE, // Khi còn category nên không xóa được
        PARENT_CANNOT_BE_SELF,          // Parent trùng chính nó
        PARENT_NOT_FOUND,               // ParentId không tồn tại
        PARENT_CIRCULAR_REFERENCE,      // Vòng lặp đa cấp
        SORT_ORDER_INVALID
    }
}
