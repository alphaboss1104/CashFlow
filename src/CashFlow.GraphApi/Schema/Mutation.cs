﻿// <auto-generated>
//  !! WARNING !! This file is auto-generated. Changes to this file will be lost.
// </auto-generated>

using System;

using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CashFlow.Command.Abstractions;
using GraphQL.Conventions;
using MediatR;

namespace CashFlow.GraphApi.Schema
{
#pragma warning disable IDE0008 // Use explicit type
    internal sealed class Mutation
    {
        private readonly IMapper _mapper;

        public Mutation(OutputTypesMapperResolver mapperResolver)
        {
            _mapper = mapperResolver();
        }

        public AccountMutations Account => new AccountMutations(_mapper);

        public CodeMutations Code => new CodeMutations(_mapper);

        public FinancialYearMutations FinancialYear => new FinancialYearMutations(_mapper);

        public SupplierMutations Supplier => new SupplierMutations(_mapper);

        public TransactionMutations Transaction => new TransactionMutations(_mapper);
    }

    internal sealed class AccountMutations
    {
        private readonly IMapper _mapper;

        public AccountMutations(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Description("Add an account")]
        public async Task<MutationInfo> Add([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddAccountParameters> parameters)
        {
            var command = new AddAccountCommand
            {
                Id = Guid.NewGuid(),
                Name = parameters.Value.Name,
                Type = parameters.Value.Type,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Rename an account")]
        public async Task<MutationInfo> Rename([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RenameAccountParameters> parameters)
        {
            var command = new RenameAccountCommand
            {
                Id = parameters.Value.Id,
                Name = parameters.Value.Name,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Change the type of an account")]
        public async Task<MutationInfo> ChangeType([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<ChangeAccountTypeParameters> parameters)
        {
            var command = new ChangeAccountTypeCommand
            {
                Id = parameters.Value.Id,
                Type = parameters.Value.Type,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Remove an account")]
        public async Task<MutationInfo> Remove([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RemoveAccountParameters> parameters)
        {
            var command = new RemoveAccountCommand
            {
                Id = parameters.Value.Id,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }
    }

    internal sealed class CodeMutations
    {
        private readonly IMapper _mapper;

        public CodeMutations(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Description("Add a code")]
        public async Task<MutationInfo> Add([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddCodeParameters> parameters)
        {
            var command = new AddCodeCommand
            {
                Name = parameters.Value.Name,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Rename a code")]
        public async Task<MutationInfo> Rename([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RenameCodeParameters> parameters)
        {
            var command = new RenameCodeCommand
            {
                OriginalName = parameters.Value.OriginalName,
                NewName = parameters.Value.NewName,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Remove a code")]
        public async Task<MutationInfo> Remove([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RemoveCodeParameters> parameters)
        {
            var command = new RemoveCodeCommand
            {
                Name = parameters.Value.Name,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }
    }

    internal sealed class FinancialYearMutations
    {
        private readonly IMapper _mapper;

        public FinancialYearMutations(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Description("Add a new financial year")]
        public async Task<MutationInfo> Add([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddFinancialYearParameters> parameters)
        {
            var command = new AddFinancialYearCommand
            {
                Id = Guid.NewGuid(),
                Name = parameters.Value.Name,
                PreviousFinancialYearId = parameters.Value.PreviousFinancialYearId,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Set the given financial year as active")]
        public async Task<MutationInfo> Activate([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<ActivateFinancialYearParameters> parameters)
        {
            var command = new ActivateFinancialYearCommand
            {
                Id = parameters.Value.Id,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }
    }

    internal sealed class SupplierMutations
    {
        private readonly IMapper _mapper;

        public SupplierMutations(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Description("Add a supplier")]
        public async Task<MutationInfo> Add([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddSupplierParameters> parameters)
        {
            var command = new AddSupplierCommand
            {
                Id = Guid.NewGuid(),
                Name = parameters.Value.Name,
                ContactInfo = parameters.Value.ContactInfo,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Rename a supplier")]
        public async Task<MutationInfo> Rename([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RenameSupplierParameters> parameters)
        {
            var command = new RenameSupplierCommand
            {
                Id = parameters.Value.Id,
                Name = parameters.Value.Name,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Update the contact info of the supplier")]
        public async Task<MutationInfo> UpdateContactInfo([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<UpdateSupplierContactInfoParameters> parameters)
        {
            var command = new UpdateSupplierContactInfoCommand
            {
                Id = parameters.Value.Id,
                ContactInfo = parameters.Value.ContactInfo,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Remove a supplier")]
        public async Task<MutationInfo> Remove([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RemoveSupplierParameters> parameters)
        {
            var command = new RemoveSupplierCommand
            {
                Id = parameters.Value.Id,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }
    }

    internal sealed class TransactionMutations
    {
        private readonly IMapper _mapper;

        public TransactionMutations(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Description("Adds an income transaction")]
        public async Task<MutationInfo> AddIncome([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddIncomeTransactionParameters> parameters)
        {
            var command = new AddIncomeTransactionCommand
            {
                Id = Guid.NewGuid(),
                FinancialYearId = parameters.Value.FinancialYearId,
                TransactionDate = parameters.Value.TransactionDate,
                AccountId = parameters.Value.AccountId,
                AmountInCents = parameters.Value.AmountInCents,
                Description = parameters.Value.Description,
                Comment = parameters.Value.Comment,
                CodeNames = parameters.Value.CodeNames,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Adds an expense transaction")]
        public async Task<MutationInfo> AddExpense([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddExpenseTransactionParameters> parameters)
        {
            var command = new AddExpenseTransactionCommand
            {
                Id = Guid.NewGuid(),
                FinancialYearId = parameters.Value.FinancialYearId,
                TransactionDate = parameters.Value.TransactionDate,
                AccountId = parameters.Value.AccountId,
                SupplierId = parameters.Value.SupplierId,
                AmountInCents = parameters.Value.AmountInCents,
                Description = parameters.Value.Description,
                Comment = parameters.Value.Comment,
                CodeNames = parameters.Value.CodeNames,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Adds a transfer transaction")]
        public async Task<MutationInfo> AddTransfer([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AddTransferTransactionParameters> parameters)
        {
            var command = new AddTransferTransactionCommand
            {
                IdOrigin = Guid.NewGuid(),
                IdDestination = Guid.NewGuid(),
                FinancialYearId = parameters.Value.FinancialYearId,
                TransactionDate = parameters.Value.TransactionDate,
                OriginAccountId = parameters.Value.OriginAccountId,
                DestinationAccountId = parameters.Value.DestinationAccountId,
                AmountInCents = parameters.Value.AmountInCents,
                Description = parameters.Value.Description,
                Comment = parameters.Value.Comment,
                CodeNames = parameters.Value.CodeNames,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Removes the latest transaction")]
        public async Task<MutationInfo> RemoveLatest([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<RemoveLatestTransactionParameters> parameters)
        {
            var command = new RemoveLatestTransactionCommand
            {
                Id = parameters.Value.Id,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Assigns a code to a transaction")]
        public async Task<MutationInfo> AssignCode([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AssignCodeToTransactionParameters> parameters)
        {
            var command = new AssignCodeToTransactionCommand
            {
                Id = parameters.Value.Id,
                CodeName = parameters.Value.CodeName,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Unassigns a code from a transaction")]
        public async Task<MutationInfo> UnassignCode([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<UnassignCodeFromTransactionParameters> parameters)
        {
            var command = new UnassignCodeFromTransactionCommand
            {
                Id = parameters.Value.Id,
                CodeName = parameters.Value.CodeName,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Update the description of a transaction")]
        public async Task<MutationInfo> UpdateDescription([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<UpdateDescriptionOfTransactionParameters> parameters)
        {
            var command = new UpdateDescriptionOfTransactionCommand
            {
                Id = parameters.Value.Id,
                Description = parameters.Value.Description,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Assign a unique evidence number to a transaction")]
        public async Task<MutationInfo> AssignEvidenceNumber([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<AssignEvidenceNumberToTransactionParameters> parameters)
        {
            var command = new AssignEvidenceNumberToTransactionCommand
            {
                Id = parameters.Value.Id,
                EvidenceNumber = parameters.Value.EvidenceNumber,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }

        [Description("Unassigns the evidence number from a transaction")]
        public async Task<MutationInfo> UnassignEvidenceNumber([Inject] IMediator mediator, [Inject] IRequestInfo requestInfo, NonNull<UnassignEvidenceNumberFromTransactionParameters> parameters)
        {
            var command = new UnassignEvidenceNumberFromTransactionCommand
            {
                Id = parameters.Value.Id,
                Headers = new CommandHeaders(correlationId: Guid.NewGuid(), identity: requestInfo.Identity, remoteIpAddress: requestInfo.IpAddress)
            };

            var result = await mediator.Send(command);

            return MutationInfo.FromCommand(command);
        }
    }
#pragma warning restore IDE0008 // Use explicit type
}
