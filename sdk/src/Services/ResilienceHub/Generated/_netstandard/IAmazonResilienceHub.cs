/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ResilienceHub.Model;

namespace Amazon.ResilienceHub
{
    /// <summary>
    /// Interface for accessing ResilienceHub
    ///
    /// AWS Resilience Hub helps you proactively prepare and protect your Amazon Web Services
    /// applications from disruptions. Resilience Hub offers continuous resiliency assessment
    /// and validation that integrates into your software development lifecycle. This enables
    /// you to uncover resiliency weaknesses, ensure recovery time objective (RTO) and recovery
    /// point objective (RPO) targets for your applications are met, and resolve issues before
    /// they are released into production.
    /// </summary>
    public partial interface IAmazonResilienceHub : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IResilienceHubPaginatorFactory Paginators { get; }
#endif
                
        #region  AddDraftAppVersionResourceMappings



        /// <summary>
        /// Adds the resource mapping for the draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDraftAppVersionResourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        Task<AddDraftAppVersionResourceMappingsResponse> AddDraftAppVersionResourceMappingsAsync(AddDraftAppVersionResourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApp



        /// <summary>
        /// Creates a Resilience Hub application. A Resilience Hub application is a collection
        /// of Amazon Web Services resources structured to prevent and recover Amazon Web Services
        /// application disruptions. To describe a Resilience Hub application, you provide an
        /// application name, resources from one or more–up to five–CloudFormation stacks, and
        /// an appropriate resiliency policy.
        /// 
        ///  <pre><code> &lt;p&gt;After you create a Resilience Hub application, you publish it
        /// so that you can run a resiliency assessment on it. You can then use recommendations
        /// from the assessment to improve resiliency by running another assessment, comparing
        /// results, and then iterating the process until you achieve your goals for recovery
        /// time objective (RTO) and recovery point objective (RPO).&lt;/p&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRecommendationTemplate



        /// <summary>
        /// Creates a new recommendation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommendationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        Task<CreateRecommendationTemplateResponse> CreateRecommendationTemplateAsync(CreateRecommendationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateResiliencyPolicy



        /// <summary>
        /// Creates a resiliency policy for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        Task<CreateResiliencyPolicyResponse> CreateResiliencyPolicyAsync(CreateResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApp



        /// <summary>
        /// Deletes an AWS Resilience Hub application. This is a destructive action that can't
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppAssessment



        /// <summary>
        /// Deletes an AWS Resilience Hub application assessment. This is a destructive action
        /// that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        Task<DeleteAppAssessmentResponse> DeleteAppAssessmentAsync(DeleteAppAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRecommendationTemplate



        /// <summary>
        /// Deletes a recommendation template. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        Task<DeleteRecommendationTemplateResponse> DeleteRecommendationTemplateAsync(DeleteRecommendationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResiliencyPolicy



        /// <summary>
        /// Deletes a resiliency policy. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        Task<DeleteResiliencyPolicyResponse> DeleteResiliencyPolicyAsync(DeleteResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApp



        /// <summary>
        /// Describes an AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppAssessment



        /// <summary>
        /// Describes an assessment for an AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        Task<DescribeAppAssessmentResponse> DescribeAppAssessmentAsync(DescribeAppAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppVersionResourcesResolutionStatus



        /// <summary>
        /// Returns the resolution status for the specified resolution identifier for an application
        /// version. If <code>resolutionId</code> is not specified, the current resolution status
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResourcesResolutionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppVersionResourcesResolutionStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        Task<DescribeAppVersionResourcesResolutionStatusResponse> DescribeAppVersionResourcesResolutionStatusAsync(DescribeAppVersionResourcesResolutionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppVersionTemplate



        /// <summary>
        /// Describes details about an AWS Resilience Hub
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        Task<DescribeAppVersionTemplateResponse> DescribeAppVersionTemplateAsync(DescribeAppVersionTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDraftAppVersionResourcesImportStatus



        /// <summary>
        /// Describes the status of importing resources to an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDraftAppVersionResourcesImportStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDraftAppVersionResourcesImportStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        Task<DescribeDraftAppVersionResourcesImportStatusResponse> DescribeDraftAppVersionResourcesImportStatusAsync(DescribeDraftAppVersionResourcesImportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeResiliencyPolicy



        /// <summary>
        /// Describes a specified resiliency policy for an AWS Resilience Hub application. The
        /// returned policy object includes creation time, data location constraints, the Amazon
        /// Resource Name (ARN) for the policy, tags, tier, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        Task<DescribeResiliencyPolicyResponse> DescribeResiliencyPolicyAsync(DescribeResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportResourcesToDraftAppVersion



        /// <summary>
        /// Imports resources from sources such as a CloudFormation stack, resource-groups, or
        /// application registry app to a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportResourcesToDraftAppVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportResourcesToDraftAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        Task<ImportResourcesToDraftAppVersionResponse> ImportResourcesToDraftAppVersionAsync(ImportResourcesToDraftAppVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlarmRecommendations



        /// <summary>
        /// Lists the alarm recommendations for a AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlarmRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        Task<ListAlarmRecommendationsResponse> ListAlarmRecommendationsAsync(ListAlarmRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppAssessments



        /// <summary>
        /// Lists the assessments for an AWS Resilience Hub application. You can use request parameters
        /// to refine the results for the response object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppAssessments service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        Task<ListAppAssessmentsResponse> ListAppAssessmentsAsync(ListAppAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppComponentCompliances



        /// <summary>
        /// Lists the compliances for an AWS Resilience Hub component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentCompliances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppComponentCompliances service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        Task<ListAppComponentCompliancesResponse> ListAppComponentCompliancesAsync(ListAppComponentCompliancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppComponentRecommendations



        /// <summary>
        /// Lists the recommendations for an AWS Resilience Hub component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppComponentRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        Task<ListAppComponentRecommendationsResponse> ListAppComponentRecommendationsAsync(ListAppComponentRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApps



        /// <summary>
        /// Lists your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppVersionResourceMappings



        /// <summary>
        /// Lists how the resources in an application version are mapped/sourced from. Mappings
        /// can be physical resource identifiers, CloudFormation stacks, resource-groups, or an
        /// application registry app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        Task<ListAppVersionResourceMappingsResponse> ListAppVersionResourceMappingsAsync(ListAppVersionResourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppVersionResources



        /// <summary>
        /// Lists all the resources in an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        Task<ListAppVersionResourcesResponse> ListAppVersionResourcesAsync(ListAppVersionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppVersions



        /// <summary>
        /// Lists the different versions for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppVersions service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        Task<ListAppVersionsResponse> ListAppVersionsAsync(ListAppVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecommendationTemplates



        /// <summary>
        /// Lists the recommendation templates for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationTemplates service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        Task<ListRecommendationTemplatesResponse> ListRecommendationTemplatesAsync(ListRecommendationTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResiliencyPolicies



        /// <summary>
        /// Lists the resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResiliencyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        Task<ListResiliencyPoliciesResponse> ListResiliencyPoliciesAsync(ListResiliencyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSopRecommendations



        /// <summary>
        /// Lists the standard operating procedure (SOP) recommendations for the Resilience Hub
        /// applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSopRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSopRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        Task<ListSopRecommendationsResponse> ListSopRecommendationsAsync(ListSopRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSuggestedResiliencyPolicies



        /// <summary>
        /// Lists the suggested resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuggestedResiliencyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuggestedResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        Task<ListSuggestedResiliencyPoliciesResponse> ListSuggestedResiliencyPoliciesAsync(ListSuggestedResiliencyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for your resources in your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTestRecommendations



        /// <summary>
        /// Lists the test recommendations for the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        Task<ListTestRecommendationsResponse> ListTestRecommendationsAsync(ListTestRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUnsupportedAppVersionResources



        /// <summary>
        /// Lists the resources that are not currently supported in AWS Resilience Hub. An unsupported
        /// resource is a resource that exists in the object that was used to create an app, but
        /// is not supported by Resilience Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUnsupportedAppVersionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUnsupportedAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        Task<ListUnsupportedAppVersionResourcesResponse> ListUnsupportedAppVersionResourcesAsync(ListUnsupportedAppVersionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PublishAppVersion



        /// <summary>
        /// Publishes a new version of a specific Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishAppVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        Task<PublishAppVersionResponse> PublishAppVersionAsync(PublishAppVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDraftAppVersionTemplate



        /// <summary>
        /// Adds or updates the app template for a draft version of a Resilience Hub app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDraftAppVersionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDraftAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        Task<PutDraftAppVersionTemplateResponse> PutDraftAppVersionTemplateAsync(PutDraftAppVersionTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveDraftAppVersionResourceMappings



        /// <summary>
        /// Removes resource mappings from a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveDraftAppVersionResourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        Task<RemoveDraftAppVersionResourceMappingsResponse> RemoveDraftAppVersionResourceMappingsAsync(RemoveDraftAppVersionResourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveAppVersionResources



        /// <summary>
        /// Resolves the resources for an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAppVersionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        Task<ResolveAppVersionResourcesResponse> ResolveAppVersionResourcesAsync(ResolveAppVersionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartAppAssessment



        /// <summary>
        /// Creates a new application assessment for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        Task<StartAppAssessmentResponse> StartAppAssessmentAsync(StartAppAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApp



        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResiliencyPolicy



        /// <summary>
        /// Updates a resiliency policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        Task<UpdateResiliencyPolicyResponse> UpdateResiliencyPolicyAsync(UpdateResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}