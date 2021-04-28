namespace Microsoft.Teams.Apps.CompanyCommunicator.Authentication
{
    public class CKEditor
    {
        public class MyAuthenticator : IAuthenticator
        {
            public Task<IUser> AuthenticateAsync(ICommandRequest commandRequest, CancellationToken cancellationToken)
            {
                var user = new User(true, null);
                return Task.FromResult((IUser)user);
            }
}
    }
}