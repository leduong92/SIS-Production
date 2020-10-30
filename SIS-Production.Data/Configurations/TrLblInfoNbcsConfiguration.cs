using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TrLblInfoNbcsConfiguration : IEntityTypeConfiguration<TrlblInfoNbcs>
    {
        public void Configure(EntityTypeBuilder<TrlblInfoNbcs> builder)
        {
            builder.ToTable("tr_lbl_info_nbcs");
            builder.HasKey(x => x.job_order_no);
            builder.HasKey(x => x.mps_no);

            builder.HasIndex(x => x.finished_goods_code);
            builder.HasIndex(x => x.entry_date);

            builder.Property(x => x.record_status).HasMaxLength(1);
            builder.Property(x => x.entry_terminal_id).HasMaxLength(10);
            builder.Property(x => x.program_id).HasMaxLength(10);
            builder.Property(x => x.update_user_code).HasMaxLength(10);

            builder.Property(x => x.company_code).HasMaxLength(5);

            builder.Property(x => x.plant_code).HasMaxLength(4);
            builder.Property(x => x.mps_no).HasMaxLength(9);
            builder.Property(x => x.data_transfer_complete_sign).HasMaxLength(1);
            builder.Property(x => x.err_sign).HasMaxLength(5);
            builder.Property(x => x.job_order_no).HasMaxLength(12);
            builder.Property(x => x.seq_no).HasMaxLength(6);
            builder.Property(x => x.ship_to_address1).HasMaxLength(60);
            builder.Property(x => x.ship_to_address2).HasMaxLength(60);
            builder.Property(x => x.ship_to_company_name1).HasMaxLength(42);
            builder.Property(x => x.ship_to_company_name2).HasMaxLength(28);
            builder.Property(x => x.line_group).HasMaxLength(6);
            builder.Property(x => x.item_sign).HasMaxLength(1);

            builder.Property(x => x.main_stock_location).HasMaxLength(4);

            builder.Property(x => x.ship_to_stock_location).HasMaxLength(4);
            builder.Property(x => x.purchase_order_no).HasMaxLength(12);
            builder.Property(x => x.made_in_japan).HasMaxLength(13);

            builder.Property(x => x.customer_item).HasMaxLength(62);
            builder.Property(x => x.customer_code).HasMaxLength(5);
            builder.Property(x => x.finished_goods_code1).HasMaxLength(20);

            builder.Property(x => x.finished_goods_code2).HasMaxLength(4);

            builder.Property(x => x.special_specification_sign).HasMaxLength(1);
            builder.Property(x => x.large_letter_type).HasMaxLength(1);
            builder.Property(x => x.box_label_type).HasMaxLength(2);
            builder.Property(x => x.ship_label).HasMaxLength(10);
            builder.Property(x => x.stock_account_no).HasMaxLength(5);
            builder.Property(x => x.lot_no).HasMaxLength(10);
            builder.Property(x => x.location_no).HasMaxLength(12);
            builder.Property(x => x.customer_order_no).HasMaxLength(10);
            builder.Property(x => x.shipping_control_code).HasMaxLength(4);
            builder.Property(x => x.print_type).HasMaxLength(1);
            builder.Property(x => x.address3).HasMaxLength(22);
            builder.Property(x => x.address4).HasMaxLength(22);

            builder.Property(x => x.delivery_place).HasMaxLength(8);

            builder.Property(x => x.denominator).HasMaxLength(1);
            builder.Property(x => x.filler).HasMaxLength(24);
            builder.Property(x => x.update_request_sign).HasMaxLength(1);

            builder.Property(x => x.customer_name).HasMaxLength(100);
            builder.Property(x => x.packing_label_type).HasMaxLength(1);
            builder.Property(x => x.jis_sign).HasMaxLength(1);

            builder.Property(x => x.cust_user_code).HasMaxLength(5);
            builder.Property(x => x.cust_user_item).HasMaxLength(30);
            builder.Property(x => x.cust_user_insp_place).HasMaxLength(4);
            builder.Property(x => x.cust_user_loc_no).HasMaxLength(12);
            builder.Property(x => x.cust_user_main_stk_loc).HasMaxLength(4);
            builder.Property(x => x.cust_user_stk_acc_no).HasMaxLength(5);
            builder.Property(x => x.packing_label_type_sign).HasMaxLength(1);
            builder.Property(x => x.box_label_print_type).HasMaxLength(1);
            builder.Property(x => x.additional_spec_code1).HasMaxLength(3);
            builder.Property(x => x.cocom_sign).HasMaxLength(1);
            builder.Property(x => x.material_mark1).HasMaxLength(8);
            builder.Property(x => x.rohs_sign).HasMaxLength(1);

            builder.Property(x => x.paper_verification_mark).HasMaxLength(2);

            builder.Property(x => x.food_app).HasMaxLength(1);
            builder.Property(x => x.trace_no).HasMaxLength(20);
            builder.Property(x => x.packing_label_form_no).HasMaxLength(10);

            builder.Property(x => x.box_label_form_no).HasMaxLength(10);
            builder.Property(x => x.qr_data).HasMaxLength(200);
            builder.Property(x => x.customer_name_1).HasMaxLength(50);

            builder.Property(x => x.customer_name_2).HasMaxLength(50);
            builder.Property(x => x.transaction_no).HasMaxLength(10);
            builder.Property(x => x.finished_goods_code).HasMaxLength(20);
            builder.Property(x => x.notes1).HasMaxLength(42);
            builder.Property(x => x.unit_of_measure).HasMaxLength(3);
            builder.Property(x => x.disposal_sign).HasMaxLength(1);
            builder.Property(x => x.comment_01).HasMaxLength(25);
            builder.Property(x => x.comment_02).HasMaxLength(25);
            builder.Property(x => x.comment_03).HasMaxLength(25);
            builder.Property(x => x.comment_04).HasMaxLength(25);
            builder.Property(x => x.comment_05).HasMaxLength(25);

            builder.Property(x => x.stock_data_type).HasMaxLength(1);

            builder.Property(x => x.customer_name_for_label).HasMaxLength(42);
            builder.Property(x => x.customer_item_for_label).HasMaxLength(42);
            builder.Property(x => x.cust_print_req_for_label).HasMaxLength(42);

            builder.Property(x => x.itemd_description_for_label).HasMaxLength(42);
        }
    }
}
