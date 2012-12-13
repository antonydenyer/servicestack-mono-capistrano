require 'capistrano/mono-deploy'

ssh_options[:keys] = %w('~/.ssh/*.pub')

role :app, "192.168.1.105"
set :user, "antony"
set :deploy_to, "~/www"

