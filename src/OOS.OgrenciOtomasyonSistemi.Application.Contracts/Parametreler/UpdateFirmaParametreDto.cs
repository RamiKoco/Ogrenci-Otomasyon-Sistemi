﻿
namespace OOS.OgrenciOtomasyonSistemi.Parametreler;
public class UpdateFirmaParametreDto : IEntityDto
{
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
}