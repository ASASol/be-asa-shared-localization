using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_asa_shared_localization.Enums.ModulFoodOrder.PrintInvoice
{
    public enum PrintInvoiceKeys
    {
        PRINT_INVOICE_NOT_FOUND,           // DBH chưa có hóa đơn
        COMPANY_NAME_REQUIRED,             // Tên công ty không được để trống
        PAYMENT_METHOD_INVALID,            // Hình thức thanh toán không hợp lệ
        INVOICE_ALREADY_ISSUED,            // Hóa đơn đã phát hành (DbhInVat = 0), không cho sửa
        REQUEST_DATA_INVALID,              // Dữ liệu yêu cầu không hợp lệ
        ORDER_NOT_FOUND                    // Không tìm thấy đơn bán hàng
    }
}
