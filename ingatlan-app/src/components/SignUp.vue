<template>
  <header class="bg-gray-100 py-4 px-6 flex items-center justify-center">
<div class="flex items-center space-x-4">
            <router-link to="/">
                <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
            </router-link> 
        </div>

        </header>
<body class="bg-gray-100 flex items-center justify-center min-h-screen">
    <div class="bg-white p-8 rounded-lg shadow-md w-full max-w-md">
        <h2 class="text-2xl font-bold text-green-600 mb-6 text-center">Registration</h2>
        <form action="#" method="POST">
            <div class="mb-6">
                <label for="name" name="name" class="block text-sm font-medium text-gray-700">Name</label>
                <input 
                    type="text" 
                    id="name" 
                    name="name" 
                    class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" 
                    placeholder="Your full name" 
                    required
                >
            </div>
            <div class="mb-4">
                <label for="email" class="block text-sm font-medium text-gray-700">E-mail</label>
                <input 
                    type="email" 
                    id="email" 
                    name="email" 
                    class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" 
                    placeholder="pelda@email.com" 
                    required
                >
            </div>
            <div class="mb-4">
                <label for="password" class="block text-sm font-medium text-gray-700">Password</label>
                <input 
                    type="password" 
                    id="password" 
                    name="password" 
                    class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" 
                    placeholder="••••••••" 
                    required
                >
            </div>
            <div class="mb-6">
                <label for="confirm-password" class="block text-sm font-medium text-gray-700">Password confirmation</label>
                <input type="password" id="confirm-password" name="confirm-password" class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" placeholder="••••••••" required>
            </div>
            <div class="mb-6">
                <label for="phone" name="phone" class="block text-sm font-medium text-gray-700">Phone number</label>
                <input 
                    type="text" 
                    id="confirm-password" 
                    name="confirm-password" 
                    class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" 
                    placeholder="+36 30 123 4567" 
                    required
                >
            </div>
            <button type="submit" class="w-full bg-green-600 text-white py-2 px-4 rounded-md hover:bg-green-700 transition duration-200">Regisztráció</button>
        </form>
    </div>
</body>
</template>

<script>

</script>