require "capistrano/mono-deploy"

ssh_options[:keys] = %w('~/.ssh/*.pub')

set :application, "service stack deployed with capistrano running on mono"
set :deploy_to, "~/www" 

role :app, "10.112.6.41"

set :user, "dev"