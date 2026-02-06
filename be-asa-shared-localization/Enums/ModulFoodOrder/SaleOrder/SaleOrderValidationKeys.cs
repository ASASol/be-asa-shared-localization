namespace be_asa_shared_localization.Enums.ModulFoodOrder.SaleOrder
{
    public enum SaleOrderValidationKeys
    {
        INVALID_SALE_METHOD,             // Hình thức bán hàng không hợp lệ
        INVALID_PAYMENT_STATUS,          // Tình trạng chi trả không hợp lệ
        INVALID_ORDER_TYPE,              // Loại hàng không hợp lệ
        DEPARTMENT_NOT_FOUND,            // Bộ phận không tồn tại
        OUTLET_NOT_FOUND,                // Outlet không tồn tại
        TABLE_NOT_FOUND,                 // Bàn/Phòng không tồn tại
        ORDER_CLOSED_OR_NOT_FOUND,       // Đơn hàng không tồn tại hoặc đã đóng
        INVALID_TIME_FORMAT,             // Giờ vào/ra không hợp lệ

        // Items & Side Orders
        ITEM_QUANTITY_MUST_BE_GREATER_THAN_ZERO, // Số lượng phải lớn hơn 0
        ITEM_NOT_FOUND_OR_DELETED,               // Món ăn không tồn tại hoặc đã xóa
        MISSING_SIDE_ORDER_REF,                  // Thiếu mã liên kết dòng món chính/kèm
        DUPLICATE_SIDE_ORDER_REF,                // Trùng mã định danh dòng
        SIDE_ORDER_NOT_ALLOWED,                  // Món không được phép bán kèm với món chính
        MANDATORY_SIDE_ORDER_MISSING,            // Thiếu món kèm bắt buộc
        PRICE_UPDATE_NOT_ALLOWED,                // Không cho phép sửa giá món
        NAME_UPDATE_NOT_ALLOWED,                 // Không cho phép sửa tên món
        ITEM_ALREADY_DELETED,                    // Món đã được xóa trước đó

        // Discount & Surcharge
        PROMO_NOT_FOUND,                         // Loại giảm giá/phụ thu không tồn tại
        INVALID_PROMO_TYPE,                      // Không đúng loại giảm giá hoặc phụ thu
        PROMO_VALUE_OUT_OF_RANGE,                // Giá trị % phải từ 0-100
        PROMO_VALUE_FIXED,                       // Giá trị đã cố định, không được sửa
        ITEM_CODE_REQUIRED,
        DISCOUNT_LABEL,                  // Nhãn "Giảm giá"
        SURCHARGE_LABEL,                 // Nhãn "Phụ thu"

        ORDER_ALREADY_PAID,              // Đơn hàng đã thanh toán xong
        ORDER_CANNOT_BE_DELETED,         // Đơn hàng không thể xóa (đã phát sinh chi tiết/thanh toán)
        INVALID_GUEST_COUNT,             // Số khách không hợp lệ
        SHIFT_CLOSED,                    // Ca làm việc đã đóng
        NOT_ENOUGH_STOCK,                // Không đủ tồn kho cho món: {0}
        VOID_REASON_REQUIRED,            // Bắt buộc phải có lý do hủy món
        KITCHEN_ALREADY_PROCESSING,       // Bếp đã bắt đầu làm, không thể chỉnh sửa/hủy
        TABLE_STILL_OCCUPIED             // Bàn vẫn đang có khách, không thể thực hiện thao tác này
    }
}
