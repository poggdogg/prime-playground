﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Prime;
using Prime.Models;

namespace Prime.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Prime.Models.Address", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressType");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("EnrolleeId");

                    b.Property<string>("Postal");

                    b.Property<string>("Province");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("EnrolleeId", "AddressType")
                        .IsUnique()
                        .HasName("IX_EnrolleeId_AddressType");

                    b.ToTable("Address");

                    b.HasDiscriminator<int>("AddressType");
                });

            modelBuilder.Entity("Prime.Models.Certification", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("CollegeCode");

                    b.Property<int>("EnrolmentId");

                    b.Property<short>("LicenseCode");

                    b.Property<string>("LicenseNumber")
                        .IsRequired();

                    b.Property<short?>("PracticeCode");

                    b.Property<DateTime>("RenewalDate");

                    b.HasKey("Id");

                    b.HasIndex("CollegeCode");

                    b.HasIndex("EnrolmentId");

                    b.HasIndex("LicenseCode");

                    b.HasIndex("PracticeCode");

                    b.ToTable("Certification");
                });

            modelBuilder.Entity("Prime.Models.College", b =>
                {
                    b.Property<short>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Prefix");

                    b.HasKey("Code");

                    b.ToTable("CollegeLookup");

                    b.HasData(
                        new
                        {
                            Code = (short)1,
                            Name = "College of Physicians and Surgeons of BC (CPSBC)",
                            Prefix = "91"
                        },
                        new
                        {
                            Code = (short)2,
                            Name = "College of Pharmacists of BC (CPBC)",
                            Prefix = "P1"
                        },
                        new
                        {
                            Code = (short)3,
                            Name = "College of Registered Nurses of BC (CRNBC)",
                            Prefix = "96"
                        },
                        new
                        {
                            Code = (short)4,
                            Name = "None"
                        });
                });

            modelBuilder.Entity("Prime.Models.CollegeLicense", b =>
                {
                    b.Property<short>("CollegeCode");

                    b.Property<short>("LicenseCode");

                    b.HasKey("CollegeCode", "LicenseCode");

                    b.HasIndex("LicenseCode");

                    b.ToTable("CollegeLicense");

                    b.HasData(
                        new
                        {
                            CollegeCode = (short)1,
                            LicenseCode = (short)2
                        },
                        new
                        {
                            CollegeCode = (short)1,
                            LicenseCode = (short)3
                        },
                        new
                        {
                            CollegeCode = (short)2,
                            LicenseCode = (short)4
                        },
                        new
                        {
                            CollegeCode = (short)2,
                            LicenseCode = (short)5
                        },
                        new
                        {
                            CollegeCode = (short)3,
                            LicenseCode = (short)1
                        },
                        new
                        {
                            CollegeCode = (short)3,
                            LicenseCode = (short)5
                        });
                });

            modelBuilder.Entity("Prime.Models.Enrollee", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactPhone");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleName");

                    b.Property<string>("PreferredFirstName");

                    b.Property<string>("PreferredLastName");

                    b.Property<string>("PreferredMiddleName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("VoiceExtension");

                    b.Property<string>("VoicePhone");

                    b.HasKey("Id");

                    b.ToTable("Enrollee");
                });

            modelBuilder.Entity("Prime.Models.Enrolment", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AppliedDate");

                    b.Property<bool?>("Approved");

                    b.Property<DateTime?>("ApprovedDate");

                    b.Property<string>("ApprovedReason");

                    b.Property<string>("DeviceProviderNumber");

                    b.Property<int>("EnrolleeId");

                    b.Property<bool?>("HasCertification");

                    b.Property<bool?>("HasConviction");

                    b.Property<string>("HasConvictionDetails");

                    b.Property<bool?>("HasDisciplinaryAction");

                    b.Property<string>("HasDisciplinaryActionDetails");

                    b.Property<bool?>("HasPharmaNetSuspended");

                    b.Property<string>("HasPharmaNetSuspendedDetails");

                    b.Property<bool?>("HasRegistrationSuspended");

                    b.Property<string>("HasRegistrationSuspendedDetails");

                    b.Property<bool?>("IsAccessingPharmaNetOnBehalfOf");

                    b.Property<bool?>("IsDeviceProvider");

                    b.Property<bool?>("IsInsulinPumpProvider");

                    b.HasKey("Id");

                    b.HasIndex("EnrolleeId");

                    b.ToTable("Enrolment");
                });

            modelBuilder.Entity("Prime.Models.Job", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnrolmentId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EnrolmentId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Prime.Models.JobName", b =>
                {
                    b.Property<short>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Code");

                    b.ToTable("JobNameLookup");

                    b.HasData(
                        new
                        {
                            Code = (short)1,
                            Name = "Medical Office Assistant"
                        },
                        new
                        {
                            Code = (short)2,
                            Name = "Midwife"
                        },
                        new
                        {
                            Code = (short)3,
                            Name = "Nurse (not nurse practitioner)"
                        },
                        new
                        {
                            Code = (short)4,
                            Name = "Pharmacy Assistant"
                        },
                        new
                        {
                            Code = (short)5,
                            Name = "Pharmacy Technician"
                        },
                        new
                        {
                            Code = (short)6,
                            Name = "Registration Clerk"
                        },
                        new
                        {
                            Code = (short)7,
                            Name = "Ward Clerk"
                        },
                        new
                        {
                            Code = (short)8,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Prime.Models.License", b =>
                {
                    b.Property<short>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Code");

                    b.ToTable("LicenseLookup");

                    b.HasData(
                        new
                        {
                            Code = (short)1,
                            Name = "Full - General"
                        },
                        new
                        {
                            Code = (short)2,
                            Name = "Full - Pharmacist"
                        },
                        new
                        {
                            Code = (short)3,
                            Name = "Full - Specialty"
                        },
                        new
                        {
                            Code = (short)4,
                            Name = "Registered Nurse"
                        },
                        new
                        {
                            Code = (short)5,
                            Name = "Temporary Registered Nurse"
                        });
                });

            modelBuilder.Entity("Prime.Models.Organization", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<DateTime?>("EndDate");

                    b.Property<int>("EnrolmentId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<short>("OrganizationTypeCode");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("EnrolmentId");

                    b.HasIndex("OrganizationTypeCode");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("Prime.Models.OrganizationName", b =>
                {
                    b.Property<short>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Code");

                    b.ToTable("OrganizationNameLookup");

                    b.HasData(
                        new
                        {
                            Code = (short)1,
                            Name = "Vancouver Island Health"
                        },
                        new
                        {
                            Code = (short)2,
                            Name = "Shoppers Drug Mart"
                        });
                });

            modelBuilder.Entity("Prime.Models.OrganizationType", b =>
                {
                    b.Property<short>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Code");

                    b.ToTable("OrganizationTypeLookup");

                    b.HasData(
                        new
                        {
                            Code = (short)1,
                            Name = "Health Authority"
                        },
                        new
                        {
                            Code = (short)2,
                            Name = "Pharmacy"
                        });
                });

            modelBuilder.Entity("Prime.Models.Practice", b =>
                {
                    b.Property<short>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Code");

                    b.ToTable("PracticeLookup");

                    b.HasData(
                        new
                        {
                            Code = (short)1,
                            Name = "Remote Practice"
                        },
                        new
                        {
                            Code = (short)2,
                            Name = "Reproductive Care"
                        },
                        new
                        {
                            Code = (short)3,
                            Name = "Sexually Transmitted Infections (STI)"
                        },
                        new
                        {
                            Code = (short)4,
                            Name = "None"
                        });
                });

            modelBuilder.Entity("Prime.Models.MailingAddress", b =>
                {
                    b.HasBaseType("Prime.Models.Address");

                    b.HasIndex("EnrolleeId")
                        .HasName("IX_Address_EnrolleeId");

                    b.ToTable("Address");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Prime.Models.PhysicalAddress", b =>
                {
                    b.HasBaseType("Prime.Models.Address");

                    b.HasIndex("EnrolleeId")
                        .HasName("IX_Address_EnrolleeId");

                    b.ToTable("Address");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Prime.Models.Certification", b =>
                {
                    b.HasOne("Prime.Models.College", "College")
                        .WithMany("Certifications")
                        .HasForeignKey("CollegeCode")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prime.Models.Enrolment", "Enrolment")
                        .WithMany("Certifications")
                        .HasForeignKey("EnrolmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prime.Models.License", "License")
                        .WithMany("Certifications")
                        .HasForeignKey("LicenseCode")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prime.Models.Practice", "Practice")
                        .WithMany("Certifications")
                        .HasForeignKey("PracticeCode");
                });

            modelBuilder.Entity("Prime.Models.CollegeLicense", b =>
                {
                    b.HasOne("Prime.Models.College", "College")
                        .WithMany("CollegeLicenses")
                        .HasForeignKey("CollegeCode")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prime.Models.License", "License")
                        .WithMany("CollegeLicenses")
                        .HasForeignKey("LicenseCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prime.Models.Enrolment", b =>
                {
                    b.HasOne("Prime.Models.Enrollee", "Enrollee")
                        .WithMany("Enrolments")
                        .HasForeignKey("EnrolleeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prime.Models.Job", b =>
                {
                    b.HasOne("Prime.Models.Enrolment", "Enrolment")
                        .WithMany("Jobs")
                        .HasForeignKey("EnrolmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prime.Models.Organization", b =>
                {
                    b.HasOne("Prime.Models.Enrolment", "Enrolment")
                        .WithMany("Organizations")
                        .HasForeignKey("EnrolmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prime.Models.OrganizationType", "OrganizationType")
                        .WithMany("Organizations")
                        .HasForeignKey("OrganizationTypeCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prime.Models.MailingAddress", b =>
                {
                    b.HasOne("Prime.Models.Enrollee", "Enrollee")
                        .WithOne("MailingAddress")
                        .HasForeignKey("Prime.Models.MailingAddress", "EnrolleeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prime.Models.PhysicalAddress", b =>
                {
                    b.HasOne("Prime.Models.Enrollee", "Enrollee")
                        .WithOne("PhysicalAddress")
                        .HasForeignKey("Prime.Models.PhysicalAddress", "EnrolleeId")
                        .HasConstraintName("FK_Address_Enrollee_EnrolleeId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
