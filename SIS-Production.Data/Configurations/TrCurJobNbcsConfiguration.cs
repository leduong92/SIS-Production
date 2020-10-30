using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.Configurations
{
    public class TrCurJobNbcsConfiguration : IEntityTypeConfiguration<TrCurJobNbcs>
    {
        public void Configure(EntityTypeBuilder<TrCurJobNbcs> builder)
        {
            builder.ToTable("tr_cur_job_nbcs");
            builder.HasKey(x => x.job_order_no);

            builder.HasIndex(x => x.mps_no);
            builder.HasIndex(x => x.entry_date);
            builder.HasIndex(x => x.finished_goods_code);
            builder.HasIndex(x => x.entry_no);
            builder.HasIndex(x => x.line_no);

            builder.Property(x => x.record_status).HasMaxLength(1);
            builder.Property(x => x.entry_terminal_id).HasMaxLength(10);
            builder.Property(x => x.program_id).HasMaxLength(10);
            builder.Property(x => x.update_user_code).HasMaxLength(10);
            builder.Property(x => x.company_code).HasMaxLength(5);
            builder.Property(x => x.plant_code).HasMaxLength(4);
            builder.Property(x => x.job_order_no).HasMaxLength(12);
            builder.Property(x => x.data_transfer_complete_sign).HasMaxLength(1);
            builder.Property(x => x.err_sign).HasMaxLength(5);
            builder.Property(x => x.parent_job_order_no).HasMaxLength(12);
            builder.Property(x => x.divide_sign).HasMaxLength(1);
            builder.Property(x => x.manufactured_curing).HasMaxLength(2);
            builder.Property(x => x.list_type_rubber).HasMaxLength(2);
            builder.Property(x => x.list_type_parts).HasMaxLength(2);
            builder.Property(x => x.purchase_order).HasMaxLength(2);
            builder.Property(x => x.process_sign7).HasMaxLength(1);
            builder.Property(x => x.process_sign8).HasMaxLength(1);
            builder.Property(x => x.process_sign9).HasMaxLength(1);
            builder.Property(x => x.process_sign10).HasMaxLength(1);
            builder.Property(x => x.urgent_schedule_sign).HasMaxLength(1);
            builder.Property(x => x.machine_set_up_sign).HasMaxLength(1);
            builder.Property(x => x.final_sign).HasMaxLength(1);
            builder.Property(x => x.jis_sign).HasMaxLength(1);
            builder.Property(x => x.set_item_sign).HasMaxLength(1);
            builder.Property(x => x.finished_goods_code).HasMaxLength(20);
            builder.Property(x => x.customer_code).HasMaxLength(5);
            builder.Property(x => x.limitation_item_sign).HasMaxLength(1);

            builder.Property(x => x.mp_code).HasMaxLength(1);
            builder.Property(x => x.enterprise_code).HasMaxLength(1);
            builder.Property(x => x.line_group).HasMaxLength(6);
            builder.Property(x => x.line_no).HasMaxLength(6);
            builder.Property(x => x.press_no).HasMaxLength(3);
            builder.Property(x => x.data_no).HasMaxLength(3);
            builder.Property(x => x.mps_no).HasMaxLength(9);
            builder.Property(x => x.customer_order_no).HasMaxLength(10);
            builder.Property(x => x.set_item_co_line_no).HasMaxLength(2);
            builder.Property(x => x.round_unit).HasMaxLength(1);
            builder.Property(x => x.packing_type).HasMaxLength(1);
            builder.Property(x => x.packing_package_type).HasMaxLength(1);

            builder.Property(x => x.packing_label_type).HasMaxLength(1);

            builder.Property(x => x.packing_label_type_sign).HasMaxLength(1);
            builder.Property(x => x.box_label_type).HasMaxLength(1);
            builder.Property(x => x.box_label_print_type).HasMaxLength(1);

            builder.Property(x => x.vendor_code).HasMaxLength(4);
            builder.Property(x => x.external_fabrication_po_no).HasMaxLength(9);
            builder.Property(x => x.nickname_no).HasMaxLength(12);

            builder.Property(x => x.material_mark1).HasMaxLength(8);
            builder.Property(x => x.compound_mark1).HasMaxLength(8);
            builder.Property(x => x.material_mark2).HasMaxLength(8);
            builder.Property(x => x.compound_mark2).HasMaxLength(8);
            builder.Property(x => x.metal_case_material_code).HasMaxLength(8);
            builder.Property(x => x.spring_material_code).HasMaxLength(8);
            builder.Property(x => x.other_material_type).HasMaxLength(8);
            builder.Property(x => x.partial_shipment_sign).HasMaxLength(1);
            builder.Property(x => x.delivery_type).HasMaxLength(1);
            builder.Property(x => x.internal_order_from_plant_code).HasMaxLength(4);
            builder.Property(x => x.cost_accounting_division).HasMaxLength(2);
            builder.Property(x => x.internal_order_from_sector).HasMaxLength(4);

            builder.Property(x => x.stock_item_sign).HasMaxLength(1);

            builder.Property(x => x.capability_sign).HasMaxLength(1);
            builder.Property(x => x.order_type).HasMaxLength(1);
            builder.Property(x => x.latest_label_sign).HasMaxLength(1);

            builder.Property(x => x.re_schedule_sign).HasMaxLength(1);
            builder.Property(x => x.parts_purchase_order_sign).HasMaxLength(1);
            builder.Property(x => x.special_specification_sign).HasMaxLength(1);

            builder.Property(x => x.internal_important_sign1).HasMaxLength(1);
            builder.Property(x => x.first_mass_production_route).HasMaxLength(1);
            builder.Property(x => x.coating_material_type).HasMaxLength(8);
            builder.Property(x => x.mold).HasMaxLength(20);
            builder.Property(x => x.mold_divide_sign).HasMaxLength(6);
            builder.Property(x => x.special_process_code).HasMaxLength(5);
            builder.Property(x => x.good_item_control_sign).HasMaxLength(1);
            builder.Property(x => x.press_no_2).HasMaxLength(3);
            builder.Property(x => x.press_no_3).HasMaxLength(3);
            builder.Property(x => x.press_no_4).HasMaxLength(3);
            builder.Property(x => x.press_no_5).HasMaxLength(3);
            builder.Property(x => x.press_no_6).HasMaxLength(3);
            builder.Property(x => x.press_no_7).HasMaxLength(3);
            builder.Property(x => x.press_no_8).HasMaxLength(3);
            builder.Property(x => x.lot_no).HasMaxLength(10);
            builder.Property(x => x.paper_verification_mark).HasMaxLength(2);
            builder.Property(x => x.update_request_sign).HasMaxLength(1);
            builder.Property(x => x.disposal_sign).HasMaxLength(1);

            builder.Property(x => x.tag_no).HasMaxLength(2);

            builder.Property(x => x.total_tag_no).HasMaxLength(2);
            builder.Property(x => x.stock_data_type).HasMaxLength(1);
            builder.Property(x => x.transaction_no).HasMaxLength(10);

            builder.Property(x => x.entry_no).HasMaxLength(8);
            builder.Property(x => x.entry_line).HasMaxLength(3);
            builder.Property(x => x.complete_sign).HasMaxLength(1);
        }
    }
}
