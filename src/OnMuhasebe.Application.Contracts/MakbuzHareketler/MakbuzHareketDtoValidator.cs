﻿using FluentValidation;
using Microsoft.Extensions.Localization;
using OnMuhasebe.Makbuzlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnMuhasebe.MakbuzHareketler;
public class MakbuzHareketDtoValidator :AbstractValidator<MakbuzHareketDto>
{
    public MakbuzHareketDtoValidator(IStringLocalizer localizer)
    {
        RuleFor(x => x.Id).Must(x => x.HasValue && x.Value != Guid.Empty).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Id"]]);

        RuleFor(x => x.OdemeTuru).IsInEnum().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["PaymentType"]])
                               .NotEmpty().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["PaymentType"]]);

        RuleFor(x => x.TakipNo).NotEmpty().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["TrackingNumber"]])
           .MaximumLength(MakbuzHareketConsts.MaxTakipNoLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["TrackingNumber"], MakbuzHareketConsts.MaxTakipNoLength]);

        RuleFor(x => x.CekBankaId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Bank"]]);

        RuleFor(x => x.CekBankaId).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["Bank"]]);

        RuleFor(x => x.CekBankaSubeId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["BankBranch"]]);

        RuleFor(x => x.CekBankaSubeId).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["BankBranch"]]);

        RuleFor(x => x.CekHesapNo).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["CheckAccountNumber"]])
             .MaximumLength(MakbuzHareketConsts.MaxCekHesapNoLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["CheckAccountNumber"], (MakbuzHareketConsts.MaxCekHesapNoLength)]);

        RuleFor(x => x.CekHesapNo).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["CheckAccountNumber"]]);

        RuleFor(x => x.BelgeNo).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["CheckNumber"]])
            .MaximumLength(MakbuzHareketConsts.MaxCekHesapNoLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["CheckNumber"], (MakbuzHareketConsts.MaxCekHesapNoLength)]);

        RuleFor(x => x.Vade).NotEmpty().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Date"]]);

        RuleFor(x => x.AsilBorclu).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek || x.OdemeTuru == OdemeTuru.Senet).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["PrincipalDebtor"]])
           .MaximumLength(MakbuzHareketConsts.MaxAsilBorcluLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["PrincipalDebtor"], (MakbuzHareketConsts.MaxAsilBorcluLength)]);

        RuleFor(x => x.AsilBorclu).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek && x.OdemeTuru != OdemeTuru.Senet).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["PrincipalDebtor"]]);

        RuleFor(x => x.Ciranta).MaximumLength(MakbuzHareketConsts.MaxCirantaLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["Endorser"], (MakbuzHareketConsts.MaxCirantaLength)]);

        RuleFor(x => x.Ciranta).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek && x.OdemeTuru != OdemeTuru.Senet).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["Endorser"]]);

        RuleFor(x => x.KasaId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Nakit).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["CashAccount"]]);

        RuleFor(x => x.BankaHesapId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Banka || x.OdemeTuru == OdemeTuru.Pos).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["BankAccount"]]);

        RuleFor(x => x.Tutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Amount"]])
            .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["Amount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.BelgeDurumu).IsInEnum().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["MeansOfPaymentState"]])
                                       .NotEmpty().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["MeansOfPaymentState"]]);

        RuleFor(x => x.Aciklama).MaximumLength(EntityConsts.MaxAciklamaLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["Description"], EntityConsts.MaxAciklamaLength]);


    }
}
