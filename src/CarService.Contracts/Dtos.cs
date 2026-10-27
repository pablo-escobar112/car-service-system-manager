namespace CarService.Contracts;

public sealed record CustomerDto(
    Guid Id,
    string FullName,
    string Phone,
    string? Email);

public sealed record VehicleDto(
    Guid Id,
    Guid CustomerId,
    string Make,
    string Model,
    string RegistrationNumber,
    int? Year);

public sealed record CreateServiceOrderRequest(
    Guid CustomerId,
    Guid VehicleId,
    string ProblemDescription,
    DateOnly CreatedAt);

public sealed record ServiceOrderDto(
    Guid Id,
    Guid CustomerId,
    Guid VehicleId,
    string ProblemDescription,
    string Status,
    decimal WorkTotal,
    decimal PartsTotal,
    decimal TotalCost);

public sealed record AddWorkItemRequest(
    string Name,
    string? Description,
    decimal Price);

public sealed record WorkItemDto(
    Guid Id,
    Guid OrderId,
    string Name,
    string? Description,
    decimal Price);

public sealed record AddPartToOrderRequest(
    Guid PartId,
    int Quantity,
    decimal UnitPrice);

public sealed record OrderPartDto(
    Guid Id,
    Guid OrderId,
    Guid PartId,
    string PartName,
    int Quantity,
    decimal UnitPrice,
    decimal LineTotal);

public sealed record ChangeOrderStatusRequest(string Status);

public sealed record ApiErrorDto(
    string ErrorCode,
    string Message);
