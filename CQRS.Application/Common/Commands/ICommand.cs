﻿namespace CQRS.Application.Common.Commands
{
	public interface ICommand { }

	public interface ICommand<out TResult> { }
}
