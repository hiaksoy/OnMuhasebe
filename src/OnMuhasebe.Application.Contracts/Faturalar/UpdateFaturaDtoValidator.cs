﻿using FluentValidation;
using Microsoft.Extensions.Localization;
using OnMuhasebe.FaturaHareketler;
using OnMuhasebe.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.Faturalar;
public class UpdateFaturaDtoValidator : AbstractValidator<UpdateFaturaDto>
{
    public UpdateFaturaDtoValidator(IStringLocalizer<OnMuhasebeResource> localizer)
    {
        RuleFor(x => x.FaturaNo).NotEmpty().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["InvoiceNumber"]])
                   .MaximumLength(FaturaConsts.MaxFaturaNoLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["InvoiceNumber"], FaturaConsts.MaxFaturaNoLength]);

        RuleFor(x => x.FaturaTarihi).NotEmpty().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Date"]]);

        RuleFor(x => x.BrutTutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["GrossAmount"]])
             .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["GrossAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.IndirimTutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["DiscountAmount"]])
             .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["DiscountAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.KdvHaricTutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["ExcludesValueAddedTaxAmount"]])
             .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["ExcludesValueAddedTaxAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.KdvTutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["ValueAddedTaxAmount"]])
             .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["ValueAddedTaxAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.NetTutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["TotalAmount"]])
             .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["TotalAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.HareketSayisi).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["NumberOfTransactions"]])
             .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["NumberOfTransactions"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.CariId).Must(x => x.HasValue && x.Value != Guid.Empty).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Customer"]]);

        RuleFor(x => x.Aciklama).MaximumLength(EntityConsts.MaxAciklamaLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["Description"], EntityConsts.MaxAciklamaLength]);

        RuleForEach(x => x.FaturaHareketler).SetValidator(y => new FaturaHareketDtoValidator(localizer));


    }
}
