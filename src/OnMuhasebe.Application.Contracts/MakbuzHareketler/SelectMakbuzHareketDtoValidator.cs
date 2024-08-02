namespace OnMuhasebe.MakbuzHareketler;
public class SelectMakbuzHareketDtoValidator : AbstractValidator<SelectMakbuzHareketDto>
{
    public SelectMakbuzHareketDtoValidator(IStringLocalizer localizer)
    {
        RuleFor(x => x.CekBankaId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Bank"]]);

        RuleFor(x => x.CekBankaSubeId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["BankBranch"]]);

        RuleFor(x => x.CekHesapNo).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["CheckAccountNumber"]])
             .MaximumLength(MakbuzHareketConsts.MaxCekHesapNoLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["CheckAccountNumber"], (MakbuzHareketConsts.MaxCekHesapNoLength)]);

        RuleFor(x => x.BelgeNo).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["CheckNumber"]])
            .MaximumLength(MakbuzHareketConsts.MaxCekHesapNoLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["CheckNumber"], (MakbuzHareketConsts.MaxCekHesapNoLength)]);

        RuleFor(x => x.AsilBorclu).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Cek || x.OdemeTuru == OdemeTuru.Senet).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["PrincipalDebtor"]])
           .MaximumLength(MakbuzHareketConsts.MaxAsilBorcluLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["PrincipalDebtor"], (MakbuzHareketConsts.MaxAsilBorcluLength)]);

        RuleFor(x => x.AsilBorclu).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek && x.OdemeTuru != OdemeTuru.Senet).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["PrincipalDebtor"]]);

        RuleFor(x => x.Ciranta).MaximumLength(MakbuzHareketConsts.MaxCirantaLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["Endorser"], (MakbuzHareketConsts.MaxCirantaLength)]);

        RuleFor(x => x.Ciranta).Empty().When(x => x.OdemeTuru != OdemeTuru.Cek && x.OdemeTuru != OdemeTuru.Senet).WithMessage(localizer[OnMuhasebeDomainErrorCodes.IsNull, localizer["Endorser"]]);

        RuleFor(x => x.KasaId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Nakit).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["CashAccount"]]);

        RuleFor(x => x.BankaHesapId).NotEmpty().When(x => x.OdemeTuru == OdemeTuru.Banka || x.OdemeTuru == OdemeTuru.Pos).WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["BankAccount"]]);
       
        RuleFor(x => x.Tutar).NotNull().WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Amount"]])
          .GreaterThanOrEqualTo(0).WithMessage(localizer[OnMuhasebeDomainErrorCodes.GreaterThenOrEqual, localizer["Amount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.Aciklama).MaximumLength(EntityConsts.MaxAciklamaLength).WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLength, localizer["Description"], EntityConsts.MaxAciklamaLength]);

    }




}
