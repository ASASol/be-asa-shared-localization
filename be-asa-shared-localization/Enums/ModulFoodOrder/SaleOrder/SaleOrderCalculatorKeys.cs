namespace be_asa_shared_localization.Enums.ModulFoodOrder.SaleOrder
{
    public enum SaleOrderCalculatorKeys
    {
        VOUCHER_CONFIG_MISSING,          // Chưa cấu hình mã tự tăng trong IT1007
        VOUCHER_GENERATION_FAILED,       // Store gen mã trả về NULL hoặc rỗng

        // Currency Configuration
        CURRENCY_CONFIG_MISSING,         // Thiếu cấu hình tham số tiền tệ (SYS_TIENTE)
        CURRENCY_DATA_NOT_FOUND,         // Không tìm thấy thông tin tỷ giá trong MCurrency
        DEFAULT_CURRENCY_MISSING,        // Không tìm thấy thông tin tiền tệ mặc định
        
        // Shift Configuration
        SHIFT_NOT_FOUND,                 // Không tìm thấy ca làm việc phù hợp
        INVALID_TIME_FORMAT,             // Định dạng thời gian không hợp lệ để tính toán
    }
}