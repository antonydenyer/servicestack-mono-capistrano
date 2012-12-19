require "capistrano/mono-deploy"

ssh_options[:keys] = %w('~/.ssh/*.pub')

set :application, "service stack deployed with capistrano running on mono"
set :deploy_to, "~/www" 

role :app, "MACHINE_NAME"

set :user, "USER_NAME"
