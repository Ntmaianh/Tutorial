﻿using FPLSP_Tutorial.WASM.Enum;

namespace FPLSP_Tutorial.WASM.Data.DataTransferObjects.User.Request;

public class UserUpdateRequest
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public List<string> RoleCodes { get; set; } = new();
    public EntityStatus Status { get; set; } = EntityStatus.Active;
}